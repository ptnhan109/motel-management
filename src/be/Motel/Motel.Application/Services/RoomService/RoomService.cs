using AutoMapper;
using Motel.Application.Helpers;
using Motel.Application.Services.RoomService.Dtos;
using Motel.Application.Services.RoomService.Models;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Motel.Application.Services.RoomService
{
    public class RoomService : Service, IRoomService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public RoomService(IRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response> AddAsync(AddRoomModel request)
        {
            request.Id = Guid.NewGuid();
            var entity = _mapper.Map<AddRoomModel, Room>(request);
            await _repository.AddAsync(entity);
            if (request.RoomImages.Count > 0)
            {
                var images = new List<SystemFile>();
                foreach (var file in request.RoomImages)
                {
                    var fileName = await file.SaveFile(EnumFileType.Room);
                    images.Add(new SystemFile()
                    {
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        Extension = Path.GetExtension(fileName),
                        FileName = fileName,
                        Id = Guid.NewGuid(),
                        FileType = EnumFileType.Room,
                        Path = FileHelper.GetPath(fileName, EnumFileType.Room),
                        MapId = request.Id.Value
                    });
                }
                await _repository.AddRangeAsync(images);
            }
            if (request.Fitments.Count > 0)
            {
                await _repository.AddRangeAsync(request.ToFitmentInRoom(request.Id.Value));

            }
            return Ok();
        }

        public async Task<Response> AddRoomDeposited(DepositDto request)
        {
            var entity = _mapper.Map<DepositDto, RoomDeposited>(request);
            await _repository.AddAsync(entity);
            await SetRoomStatus(request.RoomId, EnumRoomStatus.Deposited);

            return Ok();
        }

        public async Task<Response> DeleteAsync(Guid id)
        {
            await _repository.DeleteRangeAsync<SystemFile>(c => c.MapId.Equals(id));
            await _repository.DeleteAsync<Room>(id);
            return Ok();
        }

        public async Task<Response> DeleteRoomDeposited(Guid id)
        {
            await _repository.DeleteRangeAsync<RoomDeposited>(c => c.RoomId.Equals(id));
            await SetRoomStatus(id, EnumRoomStatus.Available);
            return Ok();
        }

        public async Task<Response> GetAllAsync(RoomFilterModel filter)
        {
            var query = _repository.GetQueryable<Room>();
            if (!string.IsNullOrEmpty(filter.keyword))
            {
                query = query.Where(c => c.Name.Equals(filter.keyword));
            }

            if (filter.StartPrice.HasValue)
            {
                query = query.Where(c => c.Price >= filter.StartPrice.Value);
            }

            if (filter.EndPrice.HasValue)
            {
                query = query.Where(c => c.Price <= filter.EndPrice.Value);
            }

            if (filter.BoardingHouseId.HasValue)
            {
                query = query.Where(c => c.BoardingHouseId.Equals(filter.BoardingHouseId.Value));
            }

            if (filter.IsSelfContainer.HasValue)
            {
                query = query.Where(c => c.IsSelfContainer.Equals(filter.IsSelfContainer.Value));
            }

            if (filter.Status.HasValue)
            {
                query = query.Where(c => c.Status.Equals(filter.Status.Value));
            }
            query = query.OrderByDescending(c => c.CreatedAt);
            var data = await _repository.FindAllAsync(query);
            var result = data.Select(room => new RoomDto()
            {
                BoardingHouseId = room.BoardingHouseId,
                Description = room.Description,
                Floor = room.Floor,
                Id = room.Id,
                IsSelfContainer = room.IsSelfContainer,
                Location = room.Location,
                MaxHuman = room.MaxHuman,
                Name = room.Name,
                Price = room.Price,
                Status = room.Status
            });
            return Ok(result);
        }

        public async Task<Response> GetPagingAsync(RoomFilterModel filter)
        {
            var query = _repository.GetQueryable<Room>();
            if (!string.IsNullOrEmpty(filter.keyword))
            {
                query = query.Where(c => c.Name.Equals(filter.keyword));
            }

            if (filter.StartPrice.HasValue)
            {
                query = query.Where(c => c.Price >= filter.StartPrice.Value);
            }

            if (filter.EndPrice.HasValue)
            {
                query = query.Where(c => c.Price <= filter.EndPrice.Value);
            }

            if (filter.BoardingHouseId.HasValue)
            {
                query = query.Where(c => c.BoardingHouseId.Equals(filter.BoardingHouseId.Value));
            }

            if (filter.IsSelfContainer.HasValue)
            {
                query = query.Where(c => c.IsSelfContainer.Equals(filter.IsSelfContainer.Value));
            }

            if (filter.Status.HasValue)
            {
                query = query.Where(c => c.Status.Equals(filter.Status.Value));
            }
            query = query.OrderByDescending(c => c.CreatedAt);
            var data = await _repository.FindPagedAsync(query, filter.pageIndex, filter.pageSize);
            var result = data.ChangeType(RoomDto.FromEntity);
            return Ok(result);
        }

        public async Task<Response> GetRoomDeposit(Guid id)
        {
            var entity = await _repository.FindAsync<RoomDeposited>(c => c.RoomId.Equals(id));
            if (entity is null)
            {
                return NotFound();
            }
            var data = _mapper.Map<RoomDeposited, DepositDto>(entity);

            return Ok(data);
        }

        private async Task SetRoomStatus(Guid id, EnumRoomStatus status)
        {
            var room = await _repository.FindAsync<Room>(id);
            room.Status = status;
            await _repository.UpdateAsync(room);
        }
    }
}
