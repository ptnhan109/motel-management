using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int Months { get; set; }

        public int? StartDatePayment { get; set; }

        public int? EndDatePayment { get; set; }

        public Guid? CityId { get; set; }
        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }
        
    }
}
