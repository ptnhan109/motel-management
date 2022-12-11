using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.StageService.Dtos
{
    public class StageDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double TotalAmount { get; set; }

        public double AmountPaid { get; set; }

        public int RoomData { get; set; }

        public int TotalRooms { get; set; }

        public int RoomPaid { get; set; }

        public bool IsComplete { get; set; }

        public static StageDto FromEntity(StagePayment stage)
            => new StageDto()
            {
                Id = stage.Id,
                Name = stage.Name,
                AmountPaid = stage.AmountPaid,
                TotalRooms = stage.TotalRooms,
                TotalAmount = stage.TotalAmount,
                RoomPaid = stage.RoomPaid,
                IsComplete = stage.IsComplete,
                RoomData = stage.RoomData
            };
    }
}
