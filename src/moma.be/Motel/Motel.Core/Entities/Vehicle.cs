﻿using Motel.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Motel.Core.Entities
{
    public class Vehicle : BaseEntity
    {
        public EnumVehicle Type { get; set; }

        [StringLength(255)]
        public string LicensePlate { get; set; }

        [StringLength(255)]
        public string Color { get; set; }

        public Guid? CustomerId{ get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }
    }
}
