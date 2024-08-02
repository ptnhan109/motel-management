using Motel.Application.Services.DashboardService.Dtos;
using Motel.Common.Generics;
using System;
using System.Threading.Tasks;

namespace Motel.Application.Services.DashboardService
{
    public interface IReportService
    {
        Task<Response> DashboardSummary();

        Task<Response> LastestPayentAsync();

        Task<Response> GetPaymentStageAsync();

        Task<Response> GetStagePaymentReportAsync(DateTime fromDate, DateTime toDate);

        Task<Response> RevenueReportAsync(DateTime fromDate, DateTime toDate, Guid? boardingHouseId);
    }
}
