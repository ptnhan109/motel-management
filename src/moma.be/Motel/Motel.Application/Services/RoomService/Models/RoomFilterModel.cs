using Motel.Application.Models;
using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.RoomService.Models
{
    public class RoomFilterModel : AppFilter
    {
        public decimal? StartPrice { get; set; } = null;

        public decimal? EndPrice { get; set; } = null;

        public Guid? BoardingHouseId { get; set; } = null;

        public EnumRoomStatus? Status { get; set; } = null;

        public bool? IsSelfContainer { get; set; } = null;
    }
}
