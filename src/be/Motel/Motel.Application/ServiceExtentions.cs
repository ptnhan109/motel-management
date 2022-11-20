using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Motel.Application.Auth;
using Motel.Application.Services.BoardingHouseService;
using Motel.Application.Services.ContractService;
using Motel.Application.Services.CustomerService;
using Motel.Application.Services.FitmentServices;
using Motel.Application.Services.RoomService;
using Motel.Application.Services.ServiceService;
using Motel.Application.Services.UserService;
using Motel.Core;
using Motel.Core.Repositories.RoomRepository;
using mps.Core.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application
{
    public static class ServiceExtentions
    {
        public static void Registers(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            services.AddScoped<IAppContextAccessor, AppContextAccessor>();

            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICryptorFactory, CryptorFactory>();
            services.AddScoped<IJwtTokenFactory, JwtTokenFactory>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBoardingHouseService,BoardingHouseService>();
            services.AddScoped<IProvideService, ProvideService>();
            services.AddScoped<IFitmentService, FitmentService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IContractService, ContractService>();

            services.AddScoped<IRoomRepository, RoomRepository>();
        }
        public static void EnableCors(this IServiceCollection services)
        {
        }
    }
}
