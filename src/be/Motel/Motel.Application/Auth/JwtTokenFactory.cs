using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Motel.Application.Auth;
using Motel.Application.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace mps.Core.Auth
{
    public class JwtTokenFactory : IJwtTokenFactory
    {
        private readonly JwtOption _options;
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler;


        public JwtTokenFactory(IOptions<JwtOption> options)
        {
            if (_jwtSecurityTokenHandler == null)
            {
                _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            }

            this._options = options.Value;
        }

        public AccessToken GenerateToken(Guid userId, string phone, string role)
        {
            var secret = Encoding.ASCII.GetBytes(_options.Secret);
            ClaimsIdentity claims = new ClaimsIdentity(new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,userId.ToString()),
                new Claim(ClaimTypes.Name,phone),
                new Claim(ClaimTypes.Role,role)
            });

            var tokenDecriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.Now.AddHours(_options.ExpireIn),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = _jwtSecurityTokenHandler.CreateToken(tokenDecriptor);

            return new AccessToken()
            {
                ExpireAt = tokenDecriptor.Expires,
                Token = _jwtSecurityTokenHandler.WriteToken(token)
            };

        }
    }
}
