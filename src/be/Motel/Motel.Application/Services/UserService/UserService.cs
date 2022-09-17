using Motel.Application.Auth;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Contants;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.UserService
{
    public class UserService : Service, IUserService
    {
        private readonly ICryptorFactory _cryptor;
        private readonly IRepository _repository;
        private readonly IJwtTokenFactory _jwtToken;

        public UserService(ICryptorFactory cryptor,
            IRepository repository,
            IJwtTokenFactory jwtToken)
        {
            _cryptor = cryptor;
            _repository = repository;
            _jwtToken = jwtToken;
        }
        public async Task<Response> Authenticate(string phone, string password)
        {
            string hashed = _cryptor.ToHashPassword(password);
            var entity = await _repository.FindAsync<AppUser>(c => c.Phone.Equals(phone) && c.Password.Equals(hashed));
            
            if(entity is null)
            {
                return BadRequest(AppCode.Error, AppMessage.UserWrongPassword);
            }
            var data = _jwtToken.GenerateToken(entity.Id, entity.Phone, entity.Role.ToString());
            return Ok(data);
        }
    }
}
