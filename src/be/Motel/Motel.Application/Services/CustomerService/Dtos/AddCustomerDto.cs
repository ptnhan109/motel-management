using Motel.Common.Enums;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Motel.Application.Services.CustomerService.Dtos
{
    public class AddCustomerDto
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public DateTime? BirthDay { get; set; }

        public string IdentificationCitizen { get; set; }

        public string IdFactory { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public EnumCareer? Career { get; set; }

        public EnumGender? Gender { get; set; }

        public string AvatarPath { get; set; }

        public string FontIdentityPath { get; set; }

        public string BackIdentityPath { get; set; }

        public Guid? RoomId { get; set; }

        public List<VehicleDto> Vehicles { get; set; }
    }
}
