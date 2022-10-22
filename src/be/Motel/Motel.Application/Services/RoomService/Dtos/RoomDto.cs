using Microsoft.AspNetCore.Http;
using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.RoomService.Dtos
{
    public class RoomDto
    {
        public Guid Id { get; set; }

        public Guid BoardingHouseId { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public int? Floor { get; set; }

        public int? MaxHuman { get; set; }

        public string Description { get; set; }

        public EnumRoomStatus Status { get; set; }

        public string Location { get; set; }

        public bool? IsSelfContainer { get; set; }
    }

    public class AddRoomModel
    {
        public Guid? Id { get; set; }

        public Guid BoardingHouseId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int? Floor { get; set; }

        public int? MaxHuman { get; set; }

        public string Description { get; set; }

        public EnumRoomStatus Status { get; set; }

        public string Location { get; set; }

        public bool? IsSelfContainer { get; set; }

        public IEnumerable<Guid> Fitments { get; set; }

        public List<IFormFile> RoomImages { get; set; }
    }
}
