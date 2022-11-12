using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Motel.Core.Entities
{
    public class UserInfo : BaseEntity
    {
        public Guid UserId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public string City { get; set; }

        [StringLength(10)]
        public string IdentityNumber { get; set; }

        [StringLength(200)]
        public string IdentityProvider { get; set; }

        [StringLength(150)]
        public string IdentityDate { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(50)]
        public string AccountBankNumber { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }
    }
}
