using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motel.Application
{
    public static class ServiceExtentions
    {
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
