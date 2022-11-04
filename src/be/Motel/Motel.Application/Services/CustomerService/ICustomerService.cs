using Motel.Application.Services.CustomerService.Dtos;
using Motel.Application.Services.CustomerService.Models;
using Motel.Common.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<Response> GetPaging(CustomerFilter request);

        Task<Response> AddCustomer(AddCustomerDto request);
    }
}
