using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Services.UserService.Dtos
{
    public class LoginRequest
    {
        public string Phone { get; set; }

        public string Password { get; set; }
    }
}
