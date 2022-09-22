using AutoMapper;
using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Common.Enums;
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
            CreateMap<BoardingHouse, BoardingHouseDto>();
            CreateMap<BoardingHouse, BoardingHouseDetail>();
            CreateMap<ServiceInBoardingHouse, ServiceInHouseDto>();

            CreateMap<Provide, ProvideDto>()
                .ForMember(dest => dest.By,d => d.MapFrom(source => source.Type.GetName()));
            CreateMap<ProvideDto, Provide>();
            CreateMap<ProvideModel, Provide>();
        }
    }
}
