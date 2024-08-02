using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Motel.Core.Entities
{
    public class StageRoom : BaseEntity
    {
        public Guid StagePaymentId { get; set; }

        [ForeignKey(nameof(StagePaymentId))]
        public virtual StagePayment Invoice { get; set; }

        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public EnumInvoicePaymentStatus PaymentStatus { get; set; }

        public decimal TotalAmount { get; set; }

        public virtual ICollection<InvoiceRoom> InvoiceRooms { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsSubtractToDeposited { get; set; }

        public bool IsCheckout { get; set; }
    }
}
