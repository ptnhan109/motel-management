﻿using Motel.Application.Services.RoomService.Dtos;
using Motel.Application.Services.RoomService.Models;
using Motel.Common.Enums;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Application.Services.RoomService
{
    public interface IRoomService
    {
        Task<Response> AddAsync(AddRoomModel request);

        Task<Response> GetPagingAsync(RoomFilterModel filter);

        Task<Response> GetAllAsync(RoomFilterModel filter);

        Task<Response> DeleteAsync(Guid id);

        Task<Response> AddRoomDeposited(DepositDto request);

        Task<Response> DeleteRoomDeposited(Guid id);

        Task<Response> GetRoomDeposit(Guid id);

        Task<Response> SetRoomStatus(Guid id, EnumRoomStatus status);
    }
}
