using AutoMapper;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Motel.Application.Auth;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.ContractService.Models;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Contants;
using Motel.Core.Entities;
using Motel.Core.Repositories.RoomRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Motel.Application.Services.ContractService
{
    public class ContractService : Service, IContractService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        private readonly IAppContextAccessor _contextAccessor;
        private readonly IRoomRepository _roomRepository;

        public ContractService(IRepository repository,
            IMapper mapper,
            IAppContextAccessor contextAccessor,
            IRoomRepository roomRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _contextAccessor = contextAccessor;
            _roomRepository = roomRepository;
        }
        public async Task<Response> AddAsync(ContractDto dto)
        {
            dto.Id = Guid.NewGuid();
            var entity = _mapper.Map<ContractDto, AppContract>(dto);
            await _repository.AddAsync(entity);
            if (dto?.Terms?.FirstOrDefault() != null)
            {
                var terms = _mapper.Map<List<AddTermDto>, List<ContractTerm>>(dto.Terms);
                foreach (var term in terms)
                {
                    term.AppContractId = dto.Id.Value;
                }
                await _repository.AddRangeAsync(terms);
            }
            await SetRoomStatus(dto.RoomId, dto.Type);
            return Ok();
        }

        public async Task<byte[]> CreateContractFile(Guid id)
        {
            var exportModel = await GetContractExportModel(id);

            var current = Directory.GetCurrentDirectory();

            var file = Path.Combine(current, "Templates", TemplateFileNames.RentContractTemplate);
            var newPath = Path.Combine(current, "Exports", $"HopDongThueNha_{DateTime.Now.ToString("yyyyddMMhhss")}.docx");
            File.Copy(file, newPath);
            using (var word = WordprocessingDocument.Open(newPath, true))
            {
                var texts = word.MainDocumentPart.Document.Descendants<Text>().Where(c => c.Text.Contains("{")).ToList();
                foreach (var text in texts)
                {
                    foreach (PropertyInfo property in typeof(AppContractExportModel).GetProperties())
                    {
                        string keyword = $"{{{property.Name}}}";
                        if (text.Text.Contains(keyword))
                        {
                            text.Text = text.Text.Replace(keyword,GetPropValue(exportModel, property.Name)?.ToString() ?? String.Empty);
                        }
                    }
                }
                word.Save();
                
            }
            var bytes = File.ReadAllBytes(newPath);
            File.Delete(newPath);
            return bytes;
        }

        public async Task<Response> GetContractPaging(ContractFilter filter)
        {
            var query = _repository.GetQueryable<AppContract>();
            if (filter.Type.HasValue)
            {
                query = query.Where(c => c.Type.Equals(filter.Type.Value));
            }

            if (filter.Status.HasValue)
            {
                query = query.Where(c => c.Status.Equals(filter.Status.Value));
            }

            if (!string.IsNullOrEmpty(filter.keyword))
            {
                query = query.Where(c => c.Name.Equals(filter.keyword));
            }

            var paging = await _repository.FindPagedAsync(query, filter.pageIndex, filter.pageSize);

            return Ok(paging.ChangeType(ContractItem.FromEntity));
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        private async Task<AppContractExportModel> GetContractExportModel(Guid id)
        {
            var contract = await _repository.FindAsync<AppContract>(id, new string[] { "ContractTerms", "Room", "Room.BoardingHouse" });
            if (contract is null)
            {
                return default;
            }
            var customer = await _repository.FindAsync<Customer>(contract.CustomerId.Value);


            var userId = _contextAccessor.GetUserId();
            var userInfo = await _repository.FindAsync<UserInfo>(c => c.UserId.Equals(userId));
            var model = new AppContractExportModel(userInfo, customer, contract, contract.Room);

            return model;
        }

        public async Task<Response> DeleteAsync(Guid id)
        {
            //TODO: send mail to customer
            var contract = await _repository.FindAsync<AppContract>(id, new string[] { "Room" });
            if(contract.Type.Equals(EnumContractType.Deposited) 
                && contract.Room.Status.Equals(EnumRoomStatus.Deposited))
            {
                contract.Room.Status = EnumRoomStatus.Available;
            }

            if(contract.Type.Equals(EnumContractType.Rent)
                && contract.Room.Status.Equals(EnumRoomStatus.Hired))
            {
                contract.Room.Status = EnumRoomStatus.Available;
            }

            await _repository.UpdateAsync(contract.Room);


            await _repository.DeleteRangeAsync<ContractTerm>(c => c.AppContractId.Equals(id));
            await _repository.DeleteAsync<AppContract>(id);

            return Ok();
        }

        public async Task<Response> GetByIdAsync(Guid id)
        {
            var contract = await _repository.FindAsync<AppContract>(id);
            if(contract is null)
            {
                return NotFound();
            }

            return Ok(ContractDto.FromEntity(contract));
        }

        public async Task<Response> GetByRoomIdAsync(Guid id, EnumContractType? type)
        {
            var contract = await _repository.FindAsync<AppContract>(c => c.RoomId.Equals(id) && (!type.HasValue || c.Type.Equals(type.Value)));
            if(contract is null)
            {
                return NotFound();
            }

            return Ok(ContractDto.FromEntity(contract));
        }

        private async Task SetRoomStatus(Guid id,EnumContractType type)
        {
            switch (type)
            {
                case EnumContractType.Deposited:
                    await _roomRepository.SetRoomStatusAsync(id, EnumRoomStatus.Deposited);
                    return;
                case EnumContractType.Rent:
                    await _roomRepository.SetRoomStatusAsync(id, EnumRoomStatus.Hired);
                    return;
                default:
                    return;
            }
        }

        public async Task<Response> SetContractStatus(ContractStatus status)
        {
            var contract = await _repository.FindAsync<AppContract>(c => c.RoomId.Equals(status.RoomId)
            && c.Type.Equals(status.Type), new string[] { "Room" });
            if (contract is null) return NotFound();
            if (status.Status.Equals(EnumContractStatus.Cancel))
            {
                if (contract.Status.Equals(EnumRoomStatus.Deposited))
                {
                    contract.Room.Status = EnumRoomStatus.Available;
                }
            }
            contract.Status = status.Status;
            return Ok();
        }
    }
}
