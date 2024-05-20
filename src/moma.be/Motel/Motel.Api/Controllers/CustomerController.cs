using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.CustomerService;
using Motel.Application.Services.CustomerService.Dtos;
using Motel.Application.Services.CustomerService.Models;
using Motel.Application.Services.UserService.Dtos;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<Response> AddAsync([FromBody] AddCustomerDto request) => await _service.AddCustomer(request);

        [HttpGet("paging")]
        public async Task<Response> GetPaging([FromQuery] CustomerFilter request) => await _service.GetPaging(request);

        [HttpGet("get-all")]
        public async Task<Response> GetAll([FromQuery] CustomerFilter request) => await _service.GetAllCustomer(request);

        [AllowAnonymous]
        [HttpPost("auth")]
        public async Task<Response> Auth([FromBody] LoginRequest request) => await _service.CustomerLogin(request);

        [HttpGet("vehicle-paging")]
        public async Task<Response> GetVehiclePaging([FromQuery] VehicleFilter request) => await _service.GetVehiclePaging(request);
    }
}
