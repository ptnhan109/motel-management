using Motel.Application.Services.DashboardService.Dtos;
using Motel.Common.Generics;
using System.Threading.Tasks;

namespace Motel.Application.Services.DashboardService
{
    public interface IReportService
    {
        Task<Response> DashboardSummary();
    }
}
