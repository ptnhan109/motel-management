using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class AppContract : BaseEntity
    {
        public Guid? CustomerId { get; set; }

        public string Name { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public Guid RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ExpiredDate { get; set; }

        public double DepositedAmount { get; set; }

        public EnumContractType Type { get; set; }

        public int? ContractDuration { get; set; }

        public EnumContractStatus Status { get; set; }
    }
}
