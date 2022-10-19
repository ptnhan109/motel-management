using AutoMapper;
using Motel.Application.Services.RoomService.Dtos;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.RoomService
{
    public class RoomService : IRoomService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public RoomService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response> AddAsync(AddRoomModel request)
        {
            request.Id = Guid.NewGuid();
            var entity = _mapper.Map<AddRoomModel, Room>(request);
            await _repository.AddAsync(entity);

        }
    }
}
