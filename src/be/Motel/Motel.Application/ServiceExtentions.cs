using Microsoft.Extensions.DependencyInjection;
using Motel.Application.Auth;
using Motel.Application.Services.BoardingHouseService;
using Motel.Application.Services.UserService;
using Motel.Core;
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
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICryptorFactory, CryptorFactory>();
            services.AddScoped<IJwtTokenFactory, JwtTokenFactory>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBoardingHouseService,BoardingHouseService>();
        }
        public static void EnableCors(this IServiceCollection services)
        {
            //services.AddCors(opt =>
            //{
            //    opt.AddPolicy("EnableCors", builder =>
            //    {
            //        builder.AllowAnyMethod()
            //                .AllowAnyHeader()
            //                .SetIsOriginAllowed(origin => true) // allow any origin  
            //                .AllowCredentials();
            //    });
            //});
        }
    }
}
