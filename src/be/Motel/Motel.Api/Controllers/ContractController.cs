using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.ContractService;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _service;

        public ContractController(IContractService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<Response> CreateContract([FromBody] ContractDto request) => await _service.AddAsync(request);
    }
}
