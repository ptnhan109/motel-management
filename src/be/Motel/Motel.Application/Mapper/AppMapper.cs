using AutoMapper;
using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Application.Services.FitmentServices.Dtos;
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
            CreateMap<BoardingHouseDetail, BoardingHouse>();
            CreateMap<ProvideInBoardingHouse, ServiceInHouseDto>();
            CreateMap<ServiceInHouseDto, ProvideInBoardingHouse>();
            CreateMap<BoardingHouseUpdate, BoardingHouse>();

            CreateMap<Provide, ProvideDto>()
                .ForMember(dest => dest.By,d => d.MapFrom(source => source.Type.GetName()));
            CreateMap<ProvideDto, Provide>();
            CreateMap<ProvideModel, Provide>();

            CreateMap<Fitment, FitmentDto>();
        }
    }
}
