using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public DateTime BirthDay { get; set; }

        public string IdentificationCitizen { get; set; }

        public string Email { get; set; }

        public EnumCareer? Career { get; set; }

        public EnumGender? Gender { get; set; }

        public string AvatarPath { get; set; }

        public string FontIdentityPath { get; set; }

        public string BackIdentityPath { get; set; }

        public Guid? RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }
    }
}
