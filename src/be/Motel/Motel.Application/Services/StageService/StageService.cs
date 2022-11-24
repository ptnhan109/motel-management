using Motel.Application.Extentions;
using Motel.Application.Services.StageService.Dtos;
using Motel.Application.Services.StageService.Models;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Contants;
using Motel.Core.Entities;
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

        public StageService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> AddStageAsync(AddStage request)
        {
            // Add Stage payment
            var stage = new StagePayment()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                InvoiceNo = request.Code,
                IsComplete = false,
                Name = request.Name,
                StageDate = request.StageDate,
                UpdatedAt = DateTime.Now
            };

            await _repository.AddAsync(stage);
            
            // add rooms in stage payment
            var stageRooms = request.Rooms.Select(c => new AddStageRoom(c, stage.Id))
                .Select(d => d.ToEntity()).ToList();
            await _repository.AddRangeAsync(stageRooms);

            // find add rooms
            var rooms = await _repository.FindAllAsync<Room>
                (room => request.Rooms.Contains(room.Id));

            var invoices = new List<InvoiceRoom>();
            // find provide used in room
            var provides = await _repository.FindAllAsync<ProvideInBoardingHouse>(
                    provideInBoarding => 
                        rooms.Select(c => c.BoardingHouseId).Contains(provideInBoarding.BoardingHouseId),null,
                    new string[] { "Provide" });
            
            foreach(var room in rooms)
            {
                var prds = provides.Where(c => c.BoardingHouseId.Equals(room.BoardingHouseId));
                var stageRoomId = stageRooms.FirstOrDefault(c => c.RoomId.Equals(room.Id)).Id;
                foreach(var prd in prds)
                {
                    var inv = new InvoiceRoom()
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        ProvideId = prd.ProvideId,
                        Name = prd.Provide.Name,
                        Amount = 0,
                        LastValue = 0,
                        NewValue = 0,
                        Price = prd.Provide.DefaultPrice,
                        StageRoomId = stageRoomId
                    };
                    invoices.Add(inv);
                }


            }
            await _repository.AddRangeAsync(invoices);
            return Ok();
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

        public async Task<Response> GetStageCodeAsync()
        {
            var count = await _repository.CountAsync<StagePayment>();
            return Ok(count.ToCode(AppPrefix.Stage));
        }
    }
}
