using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Authenticate
{
    public interface IAuthenticateService
    {
        Task<LoginResponse> Login(LoginModel request);
    }
}
