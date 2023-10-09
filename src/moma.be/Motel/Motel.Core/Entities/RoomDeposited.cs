using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class RoomDeposited : BaseEntity
    {
        public Guid RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public double DespositedValue { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string IdentityNumber { get; set; }
    }
}
