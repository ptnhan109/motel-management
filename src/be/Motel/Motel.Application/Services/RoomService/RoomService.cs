using AutoMapper;
using Motel.Application.Helpers;
using Motel.Application.Services.RoomService.Dtos;
using Motel.Common.Enums;
using Motel.Common.Generics;
using Motel.Core;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
