using AutoMapper;
using DocumentFormat.OpenXml.Vml.Office;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.InvoiceService.Dtos;
using Motel.Application.Services.StageService.Dtos;
using Motel.Common.Constants;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Response> SetInvoiceAsync(InvoiceDto dto)
        {
            var invoiceItems = _map.Map<IEnumerable<InvoiceRoomDto>, IEnumerable<InvoiceRoom>>(dto.Items);
            
            await _repository.UpdateRangeAsync(invoiceItems.Where(x => x.Id != Guid.Empty));

            await _repository.AddRangeAsync(invoiceItems.Where(x => x.Id == Guid.Empty));
            var invoiceRoom = _map.Map<StageRoomDto, StageRoom>(dto.Invoice);
            invoiceRoom.IsCheckout = dto.IsCheckout;
            invoiceRoom.IsCompleted = true;
            invoiceRoom.IsDeleted = false;
            invoiceRoom.IsSubtractToDeposited = dto.SubtractDeposited;
            await _repository.UpdateAsync(invoiceRoom);

            await SetStageDataStatus(dto.Invoice.StagePaymentId);

            var contract = await _repository.FindAsync<AppContract>(x => x.RoomId.Equals(dto.Contract.RoomId));

            if(contract != null)
            {
                contract.AdvanceAmount = dto.Contract.AdvanceAmount + dto.AdvanceAmount;
            }

            return Ok();
        }
        
        public async Task<Response> SetRoomPaymentStatusAsync(RoomPaymentStatusDto dto)
        {
            var entity = await _repository.FindAsync<StageRoom>(dto.StageRoomId);
            if (entity is null) return NotFound();

            entity.PaymentStatus = dto.Status;
            await _repository.UpdateAsync(entity);

            await SetTotalRoomPaidAsync(entity.StagePaymentId);

            if (entity.IsSubtractToDeposited)
            {
                await SubtractAdvanceAmountAsync(entity.RoomId);
            }

            if (entity.IsCheckout)
            {
                var room = await _repository.FindAsync<Room>(entity.RoomId);
                room.Status = EnumRoomStatus.Available;
            }
            return Ok();
        }

        private async Task SetTotalRoomPaidAsync(Guid id)
        {
            var roomsPaid = (await _repository.FindAllAsync<StageRoom>(
                x => x.StagePaymentId.Equals(id) && x.PaymentStatus.Equals(EnumInvoicePaymentStatus.Paid))).ToList();
            var stagePayment = await _repository.FindAsync<StagePayment>(id);

            stagePayment.RoomPaid = roomsPaid.Count;
            if (stagePayment.RoomPaid.Equals(stagePayment.TotalRooms))
            {
                stagePayment.IsComplete = true;
            }
            stagePayment.AmountPaid = roomsPaid.Sum(x => x.TotalAmount);

            await _repository.UpdateAsync(stagePayment);
        }

        private async Task SetStageDataStatus(Guid id)
        {
            var stage = await _repository.FindAsync<StagePayment>(id);
            var compeletes = await _repository.FindAllAsync<StageRoom>(c => c.StagePaymentId.Equals(id) && c.IsCompleted);
            stage.RoomData = compeletes.Count();
            stage.TotalAmount = compeletes.Sum(x => x.TotalAmount);
            stage.IsDeleted = false;
            await _repository.UpdateAsync(stage);
        }

        private async Task SubtractAdvanceAmountAsync(Guid roomId)
        {
            var contract = await _repository.FindAsync<AppContract>(
                c => c.RoomId.Equals(roomId) && c.Type == EnumContractType.Rent, new string[] { "Room" });
            if (contract is null) return;
            contract.AdvanceAmount = contract.AdvanceAmount - contract.Room.Price;

            await _repository.UpdateAsync(contract);
        }
    }
}
