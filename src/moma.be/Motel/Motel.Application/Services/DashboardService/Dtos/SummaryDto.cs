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
}
