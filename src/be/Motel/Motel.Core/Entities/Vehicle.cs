using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class Vehicle : BaseEntity
    {
        public EnumVehicle Type { get; set; }
        
        public string LicensePlate { get; set; }

        public string Color { get; set; }

        public Guid? CustomerId{ get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }
    }
}
