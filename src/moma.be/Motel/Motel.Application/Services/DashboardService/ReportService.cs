using Microsoft.EntityFrameworkCore;
using Motel.Application.Services.DashboardService.Dtos;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System.Threading.Tasks;

namespace Motel.Application.Services.DashboardService
{
    public class ReportService : Service, IReportService
    {
        private readonly IRepository _repository;

        public ReportService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<Response> DashboardSummary()
        {
            //TODO: 
            var query = _repository.GetQueryable<Room>();
            var total = await query.CountAsync();
            var hired = await query.CountAsync(x => x.Status.Equals(EnumRoomStatus.Hired));
            var deposited = await query.CountAsync(x => x.Status.Equals(EnumRoomStatus.Deposited));
            var pending = await query.CountAsync(x => x.Status.Equals(EnumRoomStatus.Pending));

            return Ok(new SummaryDto()
            {
                TotalRoomHired = hired,
                TotalRoomDeposited = deposited,
                TotalRoomPending = pending,
                TotalRooms = total
            });
        }
    }
}
