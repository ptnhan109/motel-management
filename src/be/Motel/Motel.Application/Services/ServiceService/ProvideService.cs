using AutoMapper;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.ServiceService
{
    public class ProvideService : Service, IProvideService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public ProvideService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response> GetAll()
        {
            var entities = await _repository.FindAllAsync<Provide>();
            var data = _mapper.Map<IEnumerable<Provide>,List<ProvideDto>>(entities);
            return Ok(data);
        }
    }
}
