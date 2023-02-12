using Motel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Motel.Core.Entities
{
    public class Customer : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        public DateTime BirthDay { get; set; }

        [StringLength(13)]
        public string IdentificationCitizen { get; set; }

        [StringLength(255)]
        public string IdFactory { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public EnumCareer? Career { get; set; }

        public EnumGender? Gender { get; set; }

        [StringLength(150)]
        public string AvatarPath { get; set; }

        [StringLength(150)]
        public string FontIdentityPath { get; set; }

        [StringLength(150)]
        public string BackIdentityPath { get; set; }

        public Guid? RoomId { get; set; }

        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public string Password { get; set; }
    }
}
