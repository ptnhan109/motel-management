using Motel.Application.Services.RoomService.Dtos;
using Motel.Application.Services.RoomService.Models;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Application.Services.RoomService
{
    public interface IRoomService
    {
        Task<Response> AddAsync(AddRoomModel request);

        Task<Response> GetPagingAsync(RoomFilterModel filter);

        Task<Response> DeleteAsync(Guid id);

        Task<Response> AddRoomDeposited(DepositDto request);
    }
}
