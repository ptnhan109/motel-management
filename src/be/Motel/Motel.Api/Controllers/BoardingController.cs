﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.BoardingHouseService;
using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Common.Generics;
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
    }
}