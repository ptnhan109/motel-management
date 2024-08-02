using Motel.Application.Services.DashboardService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.ReportService
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportItem>> GetRevenueReports(DateTime startDate, DateTime endDate);
    }
}
