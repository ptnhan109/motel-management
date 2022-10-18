using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.FitmentServices;
using Motel.Application.Services.ServiceService;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IProvideService _provideService;
        private readonly IFitmentService _fitmentService;

        public CategoryController(IProvideService provideService, IFitmentService fitmentService)
        {
            _provideService = provideService;
            _fitmentService = fitmentService;
        }
        [Route("provide")]
        [HttpGet]
        public async Task<Response> GetProvides()
        {
            return await _provideService.GetAll();
        }

        [Route("provide")]
        [HttpPost]
        public async Task<Response> AddProvide([FromBody] ProvideModel model)
        {
            return await _provideService.Add(model);
        }

        [Route("provide")]
        [HttpDelete]
        public async Task<Response> DeleteProvide([FromQuery] Guid id)
        {
            return await _provideService.Delete(id);
        }

        [Route("provide")]
        [HttpPut]
        public async Task<Response> UpdateProvide([FromBody] ProvideDto request)
        {
            return await _provideService.Update(request);
        }

        [Route("fitment")]
        [HttpGet]
        public async Task<Response> GetFiments() => await _fitmentService.GetAll();
    }
}
