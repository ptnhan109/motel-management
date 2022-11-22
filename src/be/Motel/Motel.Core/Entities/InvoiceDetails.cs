using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class InvoiceDetails : BaseEntity
    {
        public Guid InvoiceRoomId { get; set; }

        [ForeignKey(nameof(InvoiceRoomId))]
        public virtual InvoiceRoom InvoiceRoom { get; set; }

        public Guid? ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public virtual Provide Provide { get; set; }

        public double? LastValue { get; set; }

        public double? NewValue { get; set; }

        public double Price { get; set; }

        public double? Amount { get; set; }

        public string Name { get; set; }

    }
}
