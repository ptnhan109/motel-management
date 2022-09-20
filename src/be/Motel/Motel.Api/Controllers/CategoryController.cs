using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.ServiceService;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IProvideService _provideService;

        public CategoryController(IProvideService provideService)
        {
            _provideService = provideService;
        }
        [Route("provide")]
        [HttpGet]
        public async Task<Response> GetProvides()
        {
            return await _provideService.GetAll();
        }
    }
}
