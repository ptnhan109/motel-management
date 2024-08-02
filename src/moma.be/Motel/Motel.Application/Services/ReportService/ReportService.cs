using Microsoft.EntityFrameworkCore;
using Motel.Application.Services.DashboardService.Dtos;
using Motel.Common.Constants;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.ReportService
{
    public class ReportService : IReportService
    {
        private readonly IRepository _repository;

        public ReportService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<RevenueReportItem>> GetRevenueReports(DateTime startDate, DateTime endDate)
        {
            var from = GetFirstDayOfMonth(startDate);
            var to = GetFirstDayOfMonth(endDate);
            var data = await _repository.GetQueryable<StageRoom>(new string[] { "Invoice" })
                .Where(x => x.Invoice.StageDate >= from && x.Invoice.StageDate <= to)
                .ToListAsync();
            var items = new List<RevenueReportItem>();

            var rooms = await _repository.FindAllAsync<Room>();

            for (DateTime date = from; date < to; date = date.AddMonths(NumberConstants.One))
            {
                var revenues = data.Where(x => x.Invoice.StageDate.Month == date.Month
                                            && x.Invoice.StageDate.Year == date.Year);

                foreach (var room in rooms)
                {
                    var roomRevenue = revenues.Where(x => x.RoomId == room.Id);
                    var item = new RevenueReportItem
                    {
                        RoomId = room.Id,
                        RoomName = room.Name
                    };

                    var monthItems = new List<RoomRevenueReportItem>();

                    foreach (var revenue in roomRevenue)
                    {
                        monthItems.Add(new RoomRevenueReportItem
                        {
                            Month = revenue.Invoice.StageDate.Month,
                            MonthName = revenue.Invoice.StageDate.ToString("MM/yyyy"),
                            Amount = revenue.Invoice.TotalAmount
                        });
                    }

                    item.Items = monthItems;

                    items.Add(item);
                }
            }

            return items;

        }

        private DateTime GetFirstDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, NumberConstants.One);
        }

        private DateTime GetLastDayOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
    }
}
