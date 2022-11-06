using AutoMapper;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.ContractService
{
    public class ContractService : Service, IContractService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public ContractService(IRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response> AddAsync(ContractDto dto)
        {
            dto.Id = Guid.NewGuid();
            var entity = _mapper.Map<ContractDto, AppContract>(dto);
            await _repository.AddAsync(entity);
            if (dto.Terms.Count > 0)
            {
                var terms = _mapper.Map<List<AddTermDto>, List<ContractTerm>>(dto.Terms);
                foreach(var term in terms)
                {
                    term.AppContractId = dto.Id.Value;
                }
                await _repository.AddRangeAsync(terms);
            }
            return Ok();
        }
    }
}
