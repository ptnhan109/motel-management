using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using Motel.Application.Services.ServiceService.Dtos;
using Motel.Common.Enums;
using Motel.Common.Generics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.InvoiceService
{
    public interface IInvoiceService
    {
        Task<Response> GetByIdAsync(Guid id);
    }
}
