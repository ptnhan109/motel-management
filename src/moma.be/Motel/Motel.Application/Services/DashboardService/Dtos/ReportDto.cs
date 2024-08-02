using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.DashboardService.Dtos
{
    public class RevenueReport
    {
        public IEnumerable<string> Months { get; set; }

        public IEnumerable<RevenueReportItem> Items { get; set; }

        public IEnumerable<decimal> Totals { get; set; }
    }
    public class RevenueReportItem
    {
        public Guid RoomId { get; set; }

        public string RoomName { get; set; }

        public IEnumerable<RoomRevenueReportItem> Items { get; set; }
    }

    public class RoomRevenueReportItem
    {
        public int Month { get; set; }

        public string MonthName { get; set; }

        public decimal Amount { get; set; }
    }
}
