using Microsoft.EntityFrameworkCore;
using Motel.Application.Services.DashboardService.Dtos;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Linq;
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

        public async Task<Response> LastestPayentAsync()
        {
            var data = new LastestPayment()
            {
                Name = string.Empty,
                DebtAmount = 0,
                PaidAmount = 0,
                TotalAmount = 0
            };

            var entity = await _repository.GetQueryable<StagePayment>().OrderByDescending(x => x.StageDate)
                .FirstOrDefaultAsync();
            if (entity is null) return Ok(data);

            data.Name = entity.Name;
            data.TotalAmount = entity.TotalAmount;
            data.PaidAmount = entity.AmountPaid;
            data.DebtAmount = entity.TotalAmount - entity.AmountPaid;

            return Ok(data);
        }

        public async Task<Response> GetPaymentStageAsync()
        {
            var currentYear = new DateTime(DateTime.Now.Year,1,1);
            var payments = await _repository.GetQueryable<StagePayment>()
                .Where(x => x.CreatedAt >= currentYear)
                .OrderBy(x => x.StageDate).ToListAsync();

            var data = payments.Select(x => new ChartItem()
            {
                Label = x.StageDate.ToString("dd-MM-yyyy"),
                Value = x.TotalAmount
            });

            return Ok(data.ToList());
        }
    }
}
