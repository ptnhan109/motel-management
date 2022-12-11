using AutoMapper;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.InvoiceService.Dtos;
using Motel.Application.Services.StageService.Dtos;
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
        private readonly IMapper _map;

        public InvoiceService(IRepository repository, IMapper map)
        {
            _repository = repository;
            _map = map;
        }
        public async Task<Response> GetByIdAsync(Guid id)
        {
            var entity = await _repository.FindAsync<StageRoom>(id, new string[] { "InvoiceRooms", "Room", "Room.BoardingHouse" });
            var dto = InvoiceDto.FromEntity(entity);
            var contract = await _repository.FindAsync<AppContract>(c => c.RoomId.Equals(entity.RoomId) && c.Type == EnumContractType.Rent);
            dto.Contract = ContractDto.FromEntity(contract);
            return Ok(dto);
        }

        public async Task<Response> SetInvoice(InvoiceDto dto)
        {
            var invoiceItems = _map.Map<IEnumerable<InvoiceRoomDto>, IEnumerable<InvoiceRoom>>(dto.Items);
            await _repository.DeleteRangeAsync<InvoiceRoom>(invoice => invoice.StageRoomId.Equals(dto.Invoice.Id));
            await _repository.AddRangeAsync(invoiceItems);

            var invoiceRoom = _map.Map<StageRoomDto, StageRoom>(dto.Invoice);
            invoiceRoom.IsCompleted = true;
            invoiceRoom.IsSubtractToDeposited = dto.SubtractDeposited;
            await _repository.UpdateAsync(invoiceRoom);
            await SetStagePaymentStatus(dto.Invoice.StagePaymentId);

            await SetDepositedAmount(dto.Invoice.RoomId, dto.Contract.AdvanceAmount);

            return Ok();
        }

        private async Task SetStagePaymentStatus(Guid id)
        {
            var stage = await _repository.FindAsync<StagePayment>(id);
            var compeletes = await _repository.CountAsync<StageRoom>(c => c.StagePaymentId.Equals(id) && c.IsCompleted);
            stage.RoomData = compeletes;
            await _repository.UpdateAsync(stage);
        }

        private async Task SetDepositedAmount(Guid roomId, double amount)
        {
            var contract = await _repository.FindAsync<AppContract>(c => c.RoomId.Equals(roomId) && c.Type == EnumContractType.Rent);
            contract.AdvanceAmount = amount;
            await _repository.UpdateAsync(contract);
        }
    }
}
