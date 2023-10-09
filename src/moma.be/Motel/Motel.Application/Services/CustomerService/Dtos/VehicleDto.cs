using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Motel.Application.Services.CustomerService.Dtos
{
    public class VehicleDto
    {
        public Guid? Id { get; set; }

        public EnumVehicle Type { get; set; }

        public string LicensePlate { get; set; }

        public string Color { get; set; }
    }
}
