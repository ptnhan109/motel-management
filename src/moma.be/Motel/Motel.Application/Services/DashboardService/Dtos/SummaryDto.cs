using System.Collections.Generic;

namespace Motel.Application.Services.DashboardService.Dtos
{
    public class SummaryDto
    {
        public int TotalRooms { get; set; }

        public int TotalRoomHired { get; set; }

        public int TotalCustomer { get; set; }

        public int TotalRoomDeposited { get; set; }

        public decimal TotalDepositedAmount { get; set; }

        public int TotalRoomPending { get; set; }
    }

    public class LastestPayment
    {
        public decimal TotalAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal DebtAmount { get; set; }

        public string Name { get; set; }
    }

    public class ChartData
    {
        public string Name { get; set; }

        public IEnumerable<ChartItem> Items { get; set; }
    }

    public class ChartItem
    {
        public string Label { get; set; }

        public decimal Value { get; set; }
    }
}
