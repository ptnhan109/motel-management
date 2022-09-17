using Motel.Common.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.UserService
{
    public interface IUserService
    {
        Task<Response> Authenticate(string phone, string password);
    }
}
