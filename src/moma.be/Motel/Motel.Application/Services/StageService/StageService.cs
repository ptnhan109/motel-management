using Motel.Application.Extentions;
using Motel.Application.Services.RoomService.Models;
using Motel.Application.Services.StageService.Dtos;
using Motel.Application.Services.StageService.Models;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Contants;
using Motel.Core.Entities;
using Motel.Core.Repositories.RoomRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.StageService
{
    public class StageService : Service, IStageService
    {
        private readonly IRepository _repository;
        private readonly IRoomRepository _roomRepository;

        public StageService(IRepository repository,
            IRoomRepository roomRepository)
        {
            _repository = repository;
            _roomRepository = roomRepository;
        }

        public async Task<Response> AddStageAsync(AddStage request)
        {
            var roomStageLastest = await _roomRepository.GetNewestRoomPayments(request.Rooms);
            // Add Stage payment
            var stage = new StagePayment()
            {
                Id = Guid.NewGuid(),
                InvoiceNo = request.Code,
                IsComplete = false,
                Name = request.Name,
                StageDate = request.StageDate,
                AmountPaid = 0,
                EndDate = request.EndDate,
                RoomPaid = 0,
                TotalAmount = 0,
                RoomData = 0,
                TotalRooms = request.Rooms?.Count ?? 0,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            await _repository.AddAsync(stage);
            
            // add rooms in stage payment
            var stageRooms = request.Rooms.Select(c => new AddStageRoom(c, stage.Id))
                .Select(d => d.ToEntity()).ToList();
            await _repository.AddRangeAsync(stageRooms);

            // find add rooms
            var rooms = await _repository.FindAllAsync<Room>
                (room => request.Rooms.Contains(room.Id),null, new string[] { "Customers" });

            var invoices = new List<InvoiceRoom>();
            // find provide used in room
            var provides = await _repository.FindAllAsync<ProvideInBoardingHouse>(
                    provideInBoarding => 
                        rooms.Select(c => c.BoardingHouseId).Contains(provideInBoarding.BoardingHouseId),null,
                    new string[] { "Provide" });
            
            foreach(var room in rooms)
            {
                var prds = provides.Where(c => c.BoardingHouseId.Equals(room.BoardingHouseId));
                var lastProvides = roomStageLastest?.FirstOrDefault(c => c.RoomId.Equals(room.Id))?.InvoiceRooms;
                var stageRoomId = stageRooms.FirstOrDefault(c => c.RoomId.Equals(room.Id)).Id;
                foreach(var prd in prds)
                {
                    var lastValue = lastProvides?.FirstOrDefault(x => x.ProvideId.Equals(prd.ProvideId))?.NewValue ?? 0;
                    var inv = new InvoiceRoom()
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        ProvideId = prd.ProvideId,
                        Name = prd.Provide.Name,
                        Amount = 0,
                        LastValue = lastValue,
                        NewValue = 0,
                        Price = prd.Provide.DefaultPrice,
                        StageRoomId = stageRoomId,
                        ProvideType = prd.Provide.Type
                    };
                    InvoiceRoomProcess(room.Customers.Count, ref inv);
                    invoices.Add(inv);
                }

            }
            await _repository.AddRangeAsync(invoices);
            return Ok();
        }

        public async Task<Response> GetByIdAsync(Guid id)
        {
            var stage = await _repository.FindAsync<StagePayment>(id);

            return Ok(StageDto.FromEntity(stage));
        }

        public async Task<Response> GetPaging(StageFilterModel filter)
        {
            var query = _repository.GetQueryable<StagePayment>();
            if (!string.IsNullOrEmpty(filter.keyword))
            {
                query = query.Where(c => c.Name.Contains(filter.keyword));
            }
            var paging = await _repository.FindPagedAsync(query, filter.pageIndex, filter.pageSize);

            return Ok(paging.ChangeType(StageDto.FromEntity));
        }

        public async Task<Response> GetRoomsPagingAsync(Guid id, RoomInStageFilterModel filter)
        {
            var query = _repository.GetQueryable<StageRoom>(new string[] { "Room", "Room.BoardingHouse" })
                .Where(c => c.StagePaymentId.Equals(id));

            if (filter.BoardingId.HasValue)
            {
                query = query.Where(item => item.Room.BoardingHouseId.Equals(filter.BoardingId.Value));
            }

            if (!string.IsNullOrEmpty(filter.keyword))
            {
                query = query.Where(item => item.Room.Name.Contains(filter.keyword));
            }

            var paging = await _repository.FindPagedAsync(query,filter.pageIndex, filter.pageSize);

            return Ok(paging.ChangeType(StageRoomDto.FromEntity));
        }

        public async Task<Response> GetStageCodeAsync()
        {
            var count = await _repository.CountAsync<StagePayment>();
            return Ok(count.ToCode(AppPrefix.Stage));
        }

        private int GetNewValueByType(EnumServiceType type, int customers, int lastValue)
        {
            switch (type)
            {
                case EnumServiceType.ByMonth:
                    return lastValue + 1;
                case EnumServiceType.ByCustomer:
                    return lastValue + customers;
                case EnumServiceType.ByNumber:
                    return lastValue ;
                default:
                    return 0;
            }
        }

        private void InvoiceRoomProcess(int customers, ref InvoiceRoom invoiceRoom)
        {
            if(invoiceRoom == null) return;
            if (invoiceRoom.ProvideType.Equals(EnumServiceType.ByMonth))
            {
                invoiceRoom.LastValue = 0;
                invoiceRoom.NewValue = 1;
            }

            if (invoiceRoom.ProvideType.Equals(EnumServiceType.ByCustomer))
            {
                invoiceRoom.LastValue = 0;
                invoiceRoom.NewValue = customers;
            }

            if (invoiceRoom.ProvideType.Equals(EnumServiceType.ByNumber))
            {
                invoiceRoom.NewValue = invoiceRoom.LastValue;
            }
        }
    }
}
