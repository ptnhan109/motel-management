using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.CustomerService;
using Motel.Application.Services.CustomerService.Dtos;
using Motel.Application.Services.CustomerService.Models;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<Response> AddAsync([FromBody] AddCustomerDto request) => await _service.AddCustomer(request);

        [HttpGet("paging")]
        [AllowAnonymous]
        public async Task<Response> GetPaging([FromQuery] CustomerFilter request) => await _service.GetPaging(request);
    }
}
