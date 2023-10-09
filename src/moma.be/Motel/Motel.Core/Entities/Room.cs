using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class Room : BaseEntity
    {
        public Guid BoardingHouseId { get; set; }

        [ForeignKey(nameof(BoardingHouseId))]
        public BoardingHouse BoardingHouse { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? Floor { get; set; }

        public int? MaxHuman { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public EnumRoomStatus Status { get; set; }

        [StringLength(63)]
        public string Location { get; set; }

        public bool? IsSelfContainer { get; set; }

        public int? Count { get; set; }

        public int Area { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

        public virtual ICollection<AppContract> AppContracts { get; set; }
    }
}
