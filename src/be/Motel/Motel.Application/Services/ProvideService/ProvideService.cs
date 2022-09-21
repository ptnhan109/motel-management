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

        public async Task<Response> Add(ProvideModel model)
        {
            var entity = _mapper.Map<ProvideModel, Provide>(model);
            await _repository.AddAsync(entity);

            return Ok();
        }

        public async Task<Response> Delete(Guid id)
        {
            await _repository.DeleteAsync<Provide>(id);

            return Ok();
        }

        public async Task<Response> GetAll()
        {
            var entities = await _repository.FindAllAsync<Provide>();
            var data = _mapper.Map<IEnumerable<Provide>,List<ProvideDto>>(entities);
            return Ok(data);
        }

        public async Task<Response> Update(ProvideDto model)
        {
            var entity = _mapper.Map<ProvideDto, Provide>(model);
            await _repository.UpdateAsync(entity);

            return Ok();
        }
    }
}
