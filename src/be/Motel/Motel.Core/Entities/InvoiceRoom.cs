using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class InvoiceRoom : BaseEntity
    {
        public Guid StageRoomId { get; set; }

        [ForeignKey(nameof(StageRoomId))]
        public virtual StageRoom StageRoom { get; set; }

        public Guid? ProvideId { get; set; }

        [ForeignKey(nameof(ProvideId))]
        public virtual Provide Provide { get; set; }

        public double? LastValue { get; set; }

        public double? NewValue { get; set; }

        public double Price { get; set; }

        public double? Amount { get; set; }

        public string Name { get; set; }

    }
}
