using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MimeKit;
using Motel.Application.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services.MessageService
{
    public class MessageService : IMessageService
    {
        private readonly MailSetting _option;

        public MessageService(IOptions<MailSetting> option)
        {
            _option = option.Value;
        }
        public async Task Send(string name, string subject, string destination, string content, IFormFile attachment = null)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_option.From, _option.UserName));
            message.To.Add(new MailboxAddress(name, destination));

            message.Subject = subject;
            message.Body = new TextPart()
            {
                Text = content
            };
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {

                client.Connect(_option.Host, _option.Port, false);

                client.Authenticate(_option.UserName, _option.Password);
                await client.SendAsync(message);

                client.Disconnect(true);
            }
        }
    }
}
