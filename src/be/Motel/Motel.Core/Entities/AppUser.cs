using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Core.Entities
{
    public class AppUser : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
