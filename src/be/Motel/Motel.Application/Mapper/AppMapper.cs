using AutoMapper;
using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application.Mapper
{
    public class AppMapper : Profile
    {
        public AppMapper()
        {
            CreateMap<BoardingHouseDto, BoardingHouse>();
        }
    }
}
