using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Services.DashboardService;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _dashboardService;

        public ReportController(IReportService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        [HttpGet("summary")]
        public async Task<Response> GetSummary() => await _dashboardService.DashboardSummary();

        [HttpGet("lastest-payment")]
        public async Task<Response> GetLastestPayment() => await _dashboardService.LastestPayentAsync();

        [HttpGet("stage-payments")]
        public async Task<Response> GetStagePayment() => await _dashboardService.GetPaymentStageAsync();

        [AllowAnonymous]
        [HttpGet("report-revenue")]
        public async Task<Response> ReportRevenue([FromQuery] DateTime from, [FromQuery] DateTime to) => await _dashboardService.GetRevenueReportAsync(from, to);
    }
}
