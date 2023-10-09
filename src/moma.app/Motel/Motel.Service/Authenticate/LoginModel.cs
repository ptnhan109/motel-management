using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Authenticate
{
    public class LoginModel
    {
        public string Phone { get; set; }

        public string Password { get; set; }

        public LoginModel(string userName, string password)
        {
            Phone = userName;
            Password = password;
        }
    }
}
