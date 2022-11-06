using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class ContractTerm : BaseEntity
    {
        public Guid AppContractId { get; set; }

        [ForeignKey(nameof(AppContractId))]
        public virtual AppContract AppContract { get; set; }

        public EnumTermType Type { get; set; }

        public string Content { get; set; }
    }
}
