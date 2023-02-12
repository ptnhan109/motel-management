using Motel.Common;
using Motel.Service;
using Motel.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services
{
    public interface IHttpProvider
    {
        Task<Response> GetAsync(WebRequestModel request);

        Task<TResponse> PostAsync<TResponse>(WebRequestModel request) where TResponse : class;

        Task<Response> PostAsync(WebRequestModel request);
    }
}
