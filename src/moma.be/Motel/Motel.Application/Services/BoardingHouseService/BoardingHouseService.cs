﻿using AutoMapper;
using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.BoardingHouseService
{
    public class BoardingHouseService : Service, IBoardingHouseService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public BoardingHouseService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response> AddAsync(BoardingHouseDto request)
        {
            var entity = _mapper.Map<BoardingHouseDto,BoardingHouse>(request);
            entity.Id = Guid.NewGuid();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _repository.AddAsync(entity);

            var serviceInboarding = request.Services.Select(c => new ProvideInBoardingHouse()
            {
                Id = Guid.NewGuid(),
                BoardingHouseId = entity.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                ProvideId = c.ServiceId,
                Price = c.Price
            });

            if (serviceInboarding.Any())
            {
                await _repository.AddRangeAsync(serviceInboarding);
            }

            return Ok();
        }

        public async Task<Response> DeleteAsync(Guid id)
        {
            await _repository.DeleteRangeAsync<ProvideInBoardingHouse>(c => c.BoardingHouseId.Equals(id));
            await _repository.DeleteAsync<BoardingHouse>(id);
            return Ok();
        }

        public async Task<Response> GetAllAsync()
        {
            var entities = await _repository.FindAllAsync<BoardingHouse>();
            var data = _mapper.Map<IEnumerable<BoardingHouse>, IEnumerable<BoardingHouseDto>>(entities);

            return Ok(data);
        }

        public async Task<Response> GetAsync(Guid id)
        {
            var entity = await _repository.FindAsync<BoardingHouse>(id);
            if(entity is null)
            {
                return NotFound();
            }
            
            var services = await _repository.FindAllAsync<ProvideInBoardingHouse>(c => c.BoardingHouseId == id);
            var data = _mapper.Map<BoardingHouse, BoardingHouseDetail>(entity);
            data.Services = services;

            return Ok(data);
        }

        public async Task<Response> UpdateAsync(BoardingHouseUpdate request)
        {
            var entity = _mapper.Map<BoardingHouseUpdate, BoardingHouse>(request);
            await _repository.UpdateAsync(entity);
            await _repository.DeleteRangeAsync<ProvideInBoardingHouse>(c => c.BoardingHouseId.Equals(entity.Id));

            var services = request.Services.Select(c => c.ToEntity(request.Id));
            if (request.Services.Any())
            {
                await _repository.AddRangeAsync(services);
            }

            return Ok();
        }
    }
}
