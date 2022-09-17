using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class AppUser : BaseEntity
    {
        [StringLength(255)]
        public string Password { get; set; }

        [Column("role")]
        public EnumRole Role { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public EnumGender Gender { get; set; }

        [StringLength(255)]
        public string Mail { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        public Guid? CityId { get; set; }
        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }

        [StringLength(255)]
        public string Address { get; set; }
    }
}
