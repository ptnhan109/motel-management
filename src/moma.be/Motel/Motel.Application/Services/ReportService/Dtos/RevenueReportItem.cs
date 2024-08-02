using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.ReportService.Dtos
{
    public class RevenueReportItem
    {
        public string RoomName { get; set; }

        public IEnumerable<RevenueTimeReportItem> Times { get; set; }
    }

    public class RevenueTimeReportItem
    {
        public string MonthName { get; set; }

        public DateTime Month { get; set; }

        public decimal Amount { get; set; }
    }
}
