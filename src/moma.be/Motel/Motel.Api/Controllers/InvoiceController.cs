using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.InvoiceService;
using Motel.Application.Services.InvoiceService.Dtos;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _service;

        public InvoiceController(IInvoiceService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<Response> GetByIdAsync(Guid id) => await _service.GetByIdAsync(id);

        [HttpPut("{id}")]
        public async Task<Response> UpdateAsync(Guid id, [FromBody] InvoiceDto request)
        {
            request.Id = id;
            return await _service.SetInvoiceAsync(request);
        }

        [HttpPatch("{id}/room")]
        public async Task<Response> SetRoomPaymentStatusAsync(Guid id, [FromBody] RoomPaymentStatusDto request) => await _service.SetRoomPaymentStatusAsync(request);
    }
}
