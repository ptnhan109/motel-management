using Motel.Application.Services;
using Motel.Common;
using Motel.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Authenticate
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IHttpProvider _service;

        public AuthenticateService(IHttpProvider service)
        {
            _service = service;
        }
        public async Task<LoginResponse> Login(LoginModel request)
        {
            var req = new WebRequestModel(Constants.Url.Authenticate, HttpMethod.Post, request);

            return await _service.PostAsync<LoginResponse>(req);
        }
    }
}
