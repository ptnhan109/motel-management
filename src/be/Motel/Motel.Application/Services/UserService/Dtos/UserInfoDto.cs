using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Motel.Application.Services.UserService.Dtos
{
    public class UserInfoDto
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public string City { get; set; }

        public string IdentityNumber { get; set; }

        public string IdentityProvider { get; set; }

        public string IdentityDate { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string AccountBankNumber { get; set; }

        public string BankName { get; set; }
    }
}
