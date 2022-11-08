using AutoMapper;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using Motel.Application.Auth;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.ContractService.Models;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Contants;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Motel.Application.Services.ContractService
{
    public class ContractService : Service, IContractService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        private readonly IAppContextAccessor _contextAccessor;

        public ContractService(IRepository repository,
            IMapper mapper, IAppContextAccessor contextAccessor)
        {
            _repository = repository;
            _mapper = mapper;
            _contextAccessor = contextAccessor;
        }
        public async Task<Response> AddAsync(ContractDto dto)
        {
            dto.Id = Guid.NewGuid();
            var entity = _mapper.Map<ContractDto, AppContract>(dto);
            await _repository.AddAsync(entity);
            if (dto.Terms.Count > 0)
            {
                var terms = _mapper.Map<List<AddTermDto>, List<ContractTerm>>(dto.Terms);
                foreach (var term in terms)
                {
                    term.AppContractId = dto.Id.Value;
                }
                await _repository.AddRangeAsync(terms);
            }
            return Ok();
        }

        public async Task<Response> CreateContractFile(Guid id)
        {
            var contract = await _repository.FindAsync<AppContract>(id, new string[] { "ContractTerms", "Room" });
            var userId = _contextAccessor.GetUserId();
            var userInfo = await _repository.FindAsync<UserInfo>(c => c.UserId.Equals(userId));


            var file = Path.Combine(Directory.GetCurrentDirectory(), "Templates", TemplateFileNames.RentContractTemplate);
            using (var word = WordprocessingDocument.Open(file, true))
            {
                var document = word.MainDocumentPart.Document;
                document.InnerText.Replace("{user_name}", "NhanPT");
                //foreach (var text in document.Descendants<Text>())
                //{
                //    if (text.Text.Contains("{user_name}"))
                //    {
                //        text.Text.Replace("{user_name}", userInfo.Name);
                //    }

                //    if (text.Text.Contains("{user_dayOfBirth}"))
                //    {
                //        if (userInfo.DayOfBirth.HasValue)
                //        {
                //            text.Text.Replace("{user_dayOfBirth}", userInfo.DayOfBirth.Value.ToString("dd/MM/yyyy"));
                //        }
                //    }

                //    if (text.Text.Contains("{user_identity}"))
                //    {
                //        text.Text.Replace("{user_identity}", userInfo.IdentityNumber);
                //    }

                //    if (text.Text.Contains("{user_identity_date}"))
                //    {
                //        text.Text.Replace("{user_identity_date}", userInfo.IdentityDate);
                //    }

                //    if(text.Text.Replace())
                //}
            }

            return default;

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
    }
}
