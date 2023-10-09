using Motel.Application.Services.DashboardService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.DashboardService
{
    public interface IDashboardService
    {
        Task<SummaryDto> DashboardSummary();
    }
}
