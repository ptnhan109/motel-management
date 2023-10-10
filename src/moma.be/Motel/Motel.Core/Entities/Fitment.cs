using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Motel.Core.Entities
{
    public class Fitment : BaseEntity
    {
        [StringLength(150)]
        public string Name { get; set; }

        public bool IsCanUse { get; set; }

        public decimal RecoupPrice { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
