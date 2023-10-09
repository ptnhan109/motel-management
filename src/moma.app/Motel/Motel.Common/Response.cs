using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Common
{
    public class Response
    {
        public string Message { get; set; } = string.Empty;

        public HttpStatusCode HttpCode { get; set; }

        public string ErrorCode { get; set; } = string.Empty;

        public bool IsSucceeded { get; set; }

        public object Data { get; set; }
    }
}
