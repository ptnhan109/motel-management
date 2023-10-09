using AutoMapper;
using Motel.Application.Services.FitmentServices.Dtos;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Motel.Application.Services.FitmentServices
{
    public class FitmentService : Service, IFitmentService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public FitmentService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response> GetAll()
        {
            var entities = await _repository.FindAllAsync<Fitment>();
            var data = _mapper.Map<IEnumerable<Fitment>,IEnumerable<FitmentDto>>(entities);
            
            return Ok(data);
        }
    }
}
