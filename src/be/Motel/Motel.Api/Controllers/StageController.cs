using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.StageService;
using Motel.Application.Services.StageService.Dtos;
using Motel.Application.Services.StageService.Models;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StageController : ControllerBase
    {
        private readonly IStageService _service;

        public StageController(IStageService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<Response> GetById(Guid id) => await _service.GetByIdAsync(id);

        [HttpGet("code")]
        public async Task<Response> GetCode() => await _service.GetStageCodeAsync();

        [HttpGet("paging")]
        public async Task<Response> GetPaging([FromQuery] StageFilterModel filter) => await _service.GetPaging(filter);

        [HttpPost]
        public async Task<Response> AddAsync(AddStage request) => await _service.AddStageAsync(request);

        [HttpGet("{id}/rooms")]
        public async Task<Response> GetRoomInStageAsync(Guid id, [FromQuery] RoomInStageFilterModel request) => await _service.GetRoomsPagingAsync(id, request);
    }
}
