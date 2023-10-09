using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Auth
{
    public interface IJwtTokenFactory
    {
        AccessToken GenerateToken(Guid userId, string phone, string role);
    }
}
