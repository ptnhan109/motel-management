using Microsoft.EntityFrameworkCore;
using Motel.Common.Enums;
using Motel.Core.Data;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Core.Repositories.RoomRepository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDataContext _context;

        public RoomRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task<List<StageRoom>> GetNewestRoomPayments(IEnumerable<Guid> ids)
        {
            var queryable = await _context.StageRooms
                .Include("InvoiceRooms").Where(room => ids.Contains(room.RoomId)).ToListAsync();
            if (queryable.Any())
            {
                var stageRooms = queryable.GroupBy(d => d.RoomId).Select(d => d.OrderByDescending(c => c.CreatedAt).FirstOrDefault()).ToList();

                return stageRooms;
            }

            return default;

        }

        public async Task<Room> SetRoomStatusAsync(Guid id, EnumRoomStatus status)
        {
            var room = _context.Rooms.FirstOrDefault(c => c.Id.Equals(id));
            if (room is null)
            {
                return default;
            }

            room.Status = status;
            await _context.SaveChangesAsync();
            return room;
        }
    }
}
