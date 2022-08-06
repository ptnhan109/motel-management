using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Options;
using Motel.Application.Options;
using System;
using System.Linq;
using System.Text;

namespace Motel.Application.Auth
{
    public interface ICryptorFactory
    {
        string ToHashPassword(string password);
    }

    public class CryptorFactory : ICryptorFactory
    {
        private readonly CryptorOption _option;
        public CryptorFactory(IOptions<CryptorOption> options)
        {
            _option = options.Value;
        }

        public string ToHashPassword(string password)
        {
            var hashed = KeyDerivation.Pbkdf2(
                    password: password,
                    salt: Encoding.UTF8.GetBytes(_option.HashPasswordKey),
                    prf: KeyDerivationPrf.HMACSHA512,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8
                    );

            return Convert.ToBase64String(hashed);
        }

        private string RandomString()
        {
            var random = new Random();
            const string chars = "ABCDKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvw";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
