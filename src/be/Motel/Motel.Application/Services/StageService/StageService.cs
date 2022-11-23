using Motel.Application.Extentions;
using Motel.Application.Services.StageService.Dtos;
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
            var stageRooms = request.Rooms.Select(c => new AddStageRoom(c, stage.Id))
                .Select(d => d.ToEntity());
            var rooms = await _repository.FindAllAsync<Room>
                (room => request.Rooms.Contains(room.Id));
            var invoices = new List<InvoiceRoom>();
            var provides = await _repository.FindAllAsync<ProvideInBoardingHouse>(
                    provideInBoarding => 
                        rooms.Select(c => c.BoardingHouseId).Contains(provideInBoarding.BoardingHouseId),null,
                    new string[] { "Provide" });
            
            foreach(var room in rooms)
            {
                var prds = provides.Where(c => c.BoardingHouseId.Equals(room.BoardingHouseId));
                foreach(var prd in prds)
                {
                    var inv = new InvoiceRoom()
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        ProvideId = prd.ProvideId,
                        Name = prd.Provide.Name,
                        StageRoomId = stageRooms.FirstOrDefault(c => c.RoomId.Equals(room.Id)).Id,
                        Amount = 0,
                        LastValue = 0,
                        NewValue = 0,
                        Price = prd.Provide.DefaultPrice,
                    };
                    invoices.Add(inv);
                }


            }
            await _repository.AddRangeAsync(stageRooms);

            return Ok();
        }

        public async Task<Response> GetStageCodeAsync()
        {
            var count = await _repository.CountAsync<StagePayment>();
            return Ok(count.ToCode(AppPrefix.Stage));
        }
    }
}
