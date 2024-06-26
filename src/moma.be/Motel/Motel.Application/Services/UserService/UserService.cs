﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Motel.Application.Auth;
using Motel.Application.Services.UserService.Dtos;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Contants;
using Motel.Core.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Motel.Application.Services.UserService
{
    public class UserService : Service, IUserService
    {
        private readonly ICryptorFactory _cryptor;
        private readonly IRepository _repository;
        private readonly IJwtTokenFactory _jwtToken;
        private readonly IMapper _mapper;
        private readonly IAppContextAccessor _accessor;

        public UserService(ICryptorFactory cryptor,
            IRepository repository,
            IJwtTokenFactory jwtToken,
            IMapper mapper,
            IAppContextAccessor accessor)
        {
            _cryptor = cryptor;
            _repository = repository;
            _jwtToken = jwtToken;
            _mapper = mapper;
            _accessor = accessor;
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

        public async Task<Response> GetOwnerAsync()
        {
            var query = _repository.GetQueryable<UserInfo>();
            var data = await query.FirstOrDefaultAsync();
            if (data is null) return NotFound();

            return Ok(data);
        }

        public async Task<Response> UpdateOwnerAsync(UserInfoDto dto)
        {
            var query = _repository.GetQueryable<UserInfo>();
            var data = await query.FirstOrDefaultAsync();
            if (data is null) return NotFound();

            data.Name = dto.Name;
            data.Phone = dto.Phone;
            data.IdentityNumber = dto.IdentityNumber;
            data.IdentityProvider = dto.IdentityProvider;
            data.IdentityDate = dto.IdentityDate;
            data.Address = dto.Address;
            data.Email = dto.Email;
            data.BankName = dto.BankName;
            data.AccountBankNumber = dto.AccountBankNumber;
            data.IsDeleted = false;

            await _repository.UpdateAsync(data);
            return Ok();
        }

        public async Task<Response> UpdateUserInfoAsync(UserInfoDto dto)
        {
            var entity = await _repository.FindAsync<UserInfo>(c => c.UserId == _accessor.GetUserId());
            var map = _mapper.Map<UserInfoDto,UserInfo>(dto);
            map.UserId = _accessor.GetUserId();
            if(entity is null)
            {
                await _repository.AddAsync(map);
            }
            map.Id = entity.Id;
            await _repository.UpdateAsync(map);
            return Ok();
        }
    }
}
