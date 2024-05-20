using Microsoft.AspNetCore.Http;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.MessageService
{
    public interface IMessageService
    {
        Task Send(string name,string subject, string destination, string content, IFormFile? attachment = null);
    }
}
