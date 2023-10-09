using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.RoomService.Dtos
{
    public class SetRoomStatus
    {
        public Guid Id { get; set; }

        public EnumRoomStatus Status { get; set; }
    }
}
