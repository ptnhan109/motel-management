using Microsoft.AspNetCore.Http;
using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Motel.Application.Services.RoomService.Dtos
{
    public class RoomDto
    {
        public Guid Id { get; set; }

        public Guid BoardingHouseId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? Floor { get; set; }

        public int? MaxHuman { get; set; }

        public string Description { get; set; }

        public EnumRoomStatus Status { get; set; }

        public string Location { get; set; }

        public bool? IsSelfContainer { get; set; }

        public int Area { get; set; }

        public static RoomDto FromEntity(Room room)
            => new RoomDto()
            {
                BoardingHouseId = room.BoardingHouseId,
                Description = room.Description,
                Floor = room.Floor,
                Id = room.Id,
                IsSelfContainer = room.IsSelfContainer,
                Location = room.Location,
                MaxHuman = room.MaxHuman,
                Name = room.Name,
                Price = room.Price,
                Status = room.Status,
                Area = room.Area
            };
    }

    public class AddRoomModel
    {
        public Guid? Id { get; set; } = null;

        public Guid BoardingHouseId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? Floor { get; set; }

        public int? MaxHuman { get; set; }

        public string Description { get; set; }

        public EnumRoomStatus Status { get; set; }

        public string Location { get; set; }

        public bool? IsSelfContainer { get; set; }

        public List<Guid> Fitments { get; set; } = null;

        #nullable enable
        public List<IFormFile>? RoomImages { get; set; } = null;

        public IEnumerable<FitmentInRoom> ToFitmentInRoom(Guid id) => Fitments.Select(c => new FitmentInRoom()
        {
            Id = Guid.NewGuid(),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            FitmentId = c,
            RoomId = id,
            Quantity = 1
        });
    }
}
