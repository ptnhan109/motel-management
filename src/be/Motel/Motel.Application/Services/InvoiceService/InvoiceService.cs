using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.InvoiceService.Dtos;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.InvoiceService
{
    public class InvoiceService : Service, IInvoiceService
    {
        private readonly IRepository _repository;

        public InvoiceService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response> GetByIdAsync(Guid id)
        {
            var entity = await _repository.FindAsync<StageRoom>(id, new string[] { "InvoiceRooms", "Room", "Room.BoardingHouse" });
            var dto = InvoiceDto.FromEntity(entity);
            var contract = await _repository.FindAsync<AppContract>(c => c.RoomId.Equals(entity.RoomId) && c.Type == EnumContractType.Rent);
            dto.Contract = ContractDto.FromEntity(contract);
            return Ok(dto);
        }
    }
}
