using Motel.Application.Services.RoomService.Dtos;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Application.Services.RoomService
{
    public interface IRoomService
    {
        Task<Response> AddAsync(AddRoomModel request);
    }
}
