using AutoMapper;
using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Motel.Application.Auth;
using Motel.Application.Options;
using Motel.Application.Services.CustomerService.Dtos;
using Motel.Application.Services.CustomerService.Models;
using Motel.Application.Services.UserService.Dtos;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Contants;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.CustomerService
{
    public class CustomerService : Service, ICustomerService
    {
        private readonly IRepository _repository;
        private readonly ICryptorFactory _cryptor;
        private readonly IJwtTokenFactory _tokenFactory;
        private readonly CustomerOption _option;
        private readonly IMapper _mapper;

        public CustomerService(IRepository repository,
            ICryptorFactory cryptor,
            IOptions<CustomerOption> option,
            IJwtTokenFactory tokenFactory,
            IMapper mapper)
        {
            _repository = repository;
            _cryptor = cryptor;
            _tokenFactory = tokenFactory;
            _option = option.Value;
            _mapper = mapper;
        }

        public async Task<Response> AddCustomer(AddCustomerDto request)
        {
            request.Id = Guid.NewGuid();
            var entity = _mapper.Map<AddCustomerDto, Customer>(request);
            entity.Password = _cryptor.ToHashPassword(_option.Password);
            var customer = await _repository.AddAsync(entity);
            var vehicles = _mapper.Map<List<VehicleDto>, List<Vehicle>>(request.Vehicles);
            foreach(var vehicle in vehicles)
            {
                vehicle.CustomerId = customer.Id;
            }
            await _repository.AddRangeAsync(vehicles);
            await SetRoomStatus(request.RoomId.Value, EnumRoomStatus.Hired);
            return Ok(customer.Id);
        }

        public async Task<Response> CustomerLogin(LoginRequest request)
        {
            string password = _cryptor.ToHashPassword(request.Password);
            var customer = await _repository.FindAsync<Customer>(x => x.Phone.Equals(request.Phone) && x.Password.Equals(password));
            if (customer is null)
            {
                return BadRequest(AppCode.Error, AppMessage.UserWrongPassword);
            }
            var data = _tokenFactory.GenerateToken(customer.Id, customer.Phone, EnumRole.Customer.ToString());
            return Ok(data);
        }

        public async Task<Response> GetAllCustomer(CustomerFilter request)
        {
            var query = _repository.GetQueryable<Customer>();
            if(request.RoomId != null)
            {
                query = query.Where(c => c.RoomId.Equals(request.RoomId.Value));
            }
            var data = await query.ToListAsync();
            return Ok(data.Select(c => CustomerItem.FromEntity(c)));
        }

        public async Task<Response> GetPaging(CustomerFilter request)
        {
            var query = _repository.GetQueryable<Customer>(new string[] { "Room", "Room.BoardingHouse" });
            if (!string.IsNullOrEmpty(request.keyword))
            {
                query = query.Where(c => c.Name.Contains(request.keyword));
            }

            if (request.BoardingHouseId.HasValue)
            {
                query = query.Where(c => c.Room.BoardingHouseId.Equals(request.BoardingHouseId.Value));
            }

            if (request.RoomId.HasValue)
            {
                query = query.Where(c => c.RoomId.Equals(request.RoomId.Value));
            }

            var data = await _repository.FindPagedAsync(query, request.pageIndex, request.pageSize);

            return Ok(data.ChangeType(CustomerItem.FromEntity));

        }

        public async Task<Response> GetVehiclePaging(VehicleFilter request)
        {
            var query = _repository.GetQueryable<Vehicle>(new string[] { "Customer" });

            if (!string.IsNullOrEmpty(request.keyword))
                query = query.Where(x => x.LicensePlate.Contains(request.keyword));

            var data = await _repository.FindPagedAsync(query, request.pageIndex, request.pageSize);

            return Ok(data.ChangeType(VehicleDto.FromEntity));
        }

        private async Task SetRoomStatus(Guid id, EnumRoomStatus status)
        {
            var room = await _repository.FindAsync<Room>(id);
            room.Status = status;
            await _repository.UpdateAsync(room);
        }
    }
}
