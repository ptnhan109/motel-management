using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.BoardingHouseService;
using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Application.Services.RoomService;
using Motel.Application.Services.RoomService.Dtos;
using Motel.Application.Services.RoomService.Models;
using Motel.Common.Generics;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BoardingController : ControllerBase
    {
        private readonly IBoardingHouseService _service;

        public BoardingController(IBoardingHouseService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<Response> AddBoarding([FromBody] BoardingHouseDto request) => await _service.AddAsync(request);

        [HttpGet]
        public async Task<Response> GetBoardings() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<Response> GetBoarding(Guid id) => await _service.GetAsync(id);

        [HttpPut]
        public async Task<Response> UpdateBoarding([FromBody] BoardingHouseUpdate request) => await _service.UpdateAsync(request);

        [HttpDelete("{id}")]
        public async Task<Response> DeleteBoarding(Guid id) => await _service.DeleteAsync(id);

    }
}
