using AutoMapper;
using Motel.Application.Services.BoardingHouseService.Dtos;
using Motel.Application.Services.ContractService.Dtos;
using Motel.Application.Services.CustomerService.Dtos;
using Motel.Application.Services.FitmentServices.Dtos;
using Motel.Application.Services.InvoiceService.Dtos;
using Motel.Application.Services.RoomService.Dtos;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Application.Services.StageService.Dtos;
using Motel.Application.Services.UserService.Dtos;
using Motel.Common.Enums;
using Motel.Core.Entities;
using System;

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

            CreateMap<AddRoomModel, Room>();
            CreateMap<DepositDto, RoomDeposited>()
                .ForMember(dest => dest.Id, d => d.MapFrom(source => Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));
            CreateMap<RoomDeposited, DepositDto>();
            CreateMap<Fitment, FitmentDto>();

            CreateMap<AddCustomerDto, Customer>()
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));

            CreateMap<VehicleDto,Vehicle>()
                .ForMember(dest => dest.Id, d => d.MapFrom(source => Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));

            CreateMap<ContractDto, AppContract>()
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));
            CreateMap<AddTermDto,ContractTerm>()
                .ForMember(dest => dest.Id, d => d.MapFrom(source => Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));

            CreateMap<InvoiceRoomDto,InvoiceRoom>()
                .ForMember(dest => dest.Id, d => d.MapFrom(source => source.Id.HasValue ? source.Id : Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));

            CreateMap<StageRoomDto, StageRoom>()
                .ForMember(dest => dest.TotalAmount, d => d.MapFrom(source => source.Amount))
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));

            CreateMap<UserInfoDto, UserInfo>()
                .ForMember(dest => dest.CreatedAt, d => d.MapFrom(source => DateTime.Now))
                .ForMember(dest => dest.UpdatedAt, d => d.MapFrom(source => DateTime.Now));

        }
    }
}
