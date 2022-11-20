using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Core.Repositories.RoomRepository
{
    public interface IRoomRepository
    {
        Task<Room> SetRoomStatusAsync(Guid id, EnumRoomStatus status);
    }
}
