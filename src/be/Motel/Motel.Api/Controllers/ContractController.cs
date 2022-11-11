using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.ContractService;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.ContractService.Models;
using Motel.Common.Generics;
using Motel.Core.Contants;
using System;
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

        [HttpGet("paging")]
        public async Task<Response> GetPaging([FromQuery] ContractFilter request) => await _service.GetContractPaging(request);

        [HttpPost]
        public async Task<Response> CreateContract([FromBody] ContractDto request) => await _service.AddAsync(request);

        [HttpPost("{id}/export")]
        public async Task<IActionResult> ExportContract(Guid id)
        {
            var name = $"HopDongThueTro_{DateTime.Now.ToString("yyyyMMddhhss")}.docx";
            var content = await _service.CreateContractFile(id);
            return File(
                fileContents: content,
                contentType: MimeFile.Docx,
                fileDownloadName: name
                );
        }
    } 
}
