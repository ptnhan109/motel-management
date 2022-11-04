using AutoMapper;
using Motel.Application.Services.CustomerService.Dtos;
using Motel.Application.Services.CustomerService.Models;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
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
        private readonly IMapper _mapper;

        public CustomerService(IRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response> AddCustomer(AddCustomerDto request)
        {
            request.Id = Guid.NewGuid();
            var entity = _mapper.Map<AddCustomerDto, Customer>(request);
            await _repository.AddAsync(entity);
            var vehicles = _mapper.Map<List<VehicleDto>, List<Vehicle>>(request.Vehicles);
            await _repository.AddRangeAsync(vehicles);
            await SetRoomStatus(request.RoomId.Value, EnumRoomStatus.Hired);
            return Ok();
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

        private async Task SetRoomStatus(Guid id, EnumRoomStatus status)
        {
            var room = await _repository.FindAsync<Room>(id);
            room.Status = status;
            await _repository.UpdateAsync(room);
        }
    }
}
