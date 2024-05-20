using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class FitmentInRoom : BaseEntity
    {
        public Guid RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public Guid FitmentId { get; set; }
        [ForeignKey(nameof(FitmentId))]
        public virtual Fitment Fitment { get; set; }

        public int Quantity { get; set; }
    }
}
