using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Motel.Core.Entities
{
    public class BoardingHouse : BaseEntity
    {
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public int? DateRetalPayment { get; set; }
    }
}
