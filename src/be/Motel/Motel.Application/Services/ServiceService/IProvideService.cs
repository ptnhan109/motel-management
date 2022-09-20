using Motel.Common.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.ServiceService
{
    public interface IProvideService
    {
        Task<Response> GetAll();
    }
}
