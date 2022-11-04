using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.RoomService.Dtos;
using Motel.Application.Services.RoomService.Models;
using Motel.Common.Generics;
using System.Linq;
using System.Threading.Tasks;
using System;
using Motel.Application.Services.RoomService;
using Microsoft.AspNetCore.Authorization;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _service;

        public RoomController(IRoomService service)
        {
            _service = service;
        }

        [Route("{boardingId}/rooms")]
        [HttpPost]
        [Consumes("multipart/form-data")]
        [DisableRequestSizeLimit]
        public async Task<Response> AddRoom(Guid boardingId, [FromForm] AddRoomModel request)
        {
            var files = Request.Form.Files;
            request.RoomImages = files.ToList();
            return await _service.AddAsync(request);
        }

        [Route("rooms")]
        [HttpGet]
        public async Task<Response> GetPaging([FromQuery] RoomFilterModel request)
            => await _service.GetPagingAsync(request);

        [Route("get-all")]
        [HttpGet]
        public async Task<Response> GetAll([FromQuery] RoomFilterModel request) => await _service.GetAllAsync(request);

        [Route("{id}")]
        [HttpDelete]
        public async Task<Response> Delete(Guid id) => await _service.DeleteAsync(id);

        [Route("{id}/room-deposit")]
        [HttpPost]
        public async Task<Response> AddRoomDeposit(Guid id, [FromBody] DepositDto request)
        {
            request.RoomId = id;
            return await _service.AddRoomDeposited(request);
        }

        [Route("{id}/room-deposit")]
        [HttpDelete]
        public async Task<Response> DeleteRoomDeposit(Guid id)
        {
            return await _service.DeleteRoomDeposited(id);
        }

        [Route("{id}/room-deposit")]
        [HttpGet]
        public async Task<Response> GetRoomDeposit(Guid id)
        {
            return await _service.GetRoomDeposit(id);
        }
    }
}
