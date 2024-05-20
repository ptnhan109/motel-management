using Motel.Common.Enums;
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

        public decimal? LastValue { get; set; }

        public decimal? NewValue { get; set; }

        public decimal Price { get; set; }

        public decimal? Amount { get; set; }

        public string Name { get; set; }

        public EnumServiceType ProvideType { get; set; }

    }
}
