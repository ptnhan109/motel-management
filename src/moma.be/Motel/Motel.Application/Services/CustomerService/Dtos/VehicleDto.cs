using Motel.Common.Enums;
using Motel.Core.Entities;
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

        public string? CustomerName { get; set; }

        public static VehicleDto FromEntity(Vehicle entity)
        {
            return new VehicleDto()
            {
                Id = entity.Id,
                Color = entity.Color,
                LicensePlate = entity.LicensePlate,
                Type = entity.Type,
                CustomerName = entity.Customer.Name
            };
        }
    }
}
