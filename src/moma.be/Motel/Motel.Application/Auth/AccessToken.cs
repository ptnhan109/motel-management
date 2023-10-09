using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Auth
{
    public class AccessToken
    {
        public string Token { get; set; }

        public DateTime? ExpireAt { get; set; }
    }
}
