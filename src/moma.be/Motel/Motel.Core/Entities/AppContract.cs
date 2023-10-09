using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class AppContract : BaseEntity
    {
        [StringLength(100)]
        public string ContractNo { get; set; }

        public Guid? CustomerId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(63)]
        public string CustomerName { get; set; }

        [StringLength(16)]
        public string CustomerPhone { get; set; }

        public Guid RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public decimal DepositedAmount { get; set; }

        public EnumContractType Type { get; set; }

        public int? ContractDuration { get; set; }

        public EnumContractStatus Status { get; set; }

        public decimal? AdvanceAmount { get; set; }

        public virtual ICollection<ContractTerm> ContractTerms { get; set; }
    }
}
