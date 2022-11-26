using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Motel.Application.Services.RoomService.Models;
using Motel.Application.Services.StageService.Dtos;
using Motel.Application.Services.StageService.Models;
using Motel.Common.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.StageService
{
    public interface IStageService
    {
        Task<Response> GetStageCodeAsync();

        Task<Response> AddStageAsync(AddStage request);

        Task<Response> GetPaging(StageFilterModel filter);

        Task<Response> GetRoomsPagingAsync(Guid id, RoomInStageFilterModel filter);
    }
}
