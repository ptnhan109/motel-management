using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.UserService;
using Motel.Application.Services.UserService.Dtos;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("info")]
        public async Task<Response> GetOwnerInfoAsync() => await _service.GetOwnerAsync();

        [HttpPut("info")]
        public async Task<Response> UpdateOwnerInfoAsync([FromBody] UserInfoDto request) => await _service.UpdateOwnerAsync(request);

    }
}
