using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class StagePayment : BaseEntity
    {
        public string InvoiceNo { get; set; }

        public string Name { get; set; }

        public DateTime StageDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal AmountPaid { get; set; }

        public int RoomData { get; set; }

        public int TotalRooms { get; set; }

        public int RoomPaid { get; set; }

        public bool IsComplete { get; set; }

        public virtual ICollection<StageRoom> StageRooms { get; set; }
    }
}
