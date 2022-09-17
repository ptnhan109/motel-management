using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Motel.Common.Generics
{
    public class Response
    {
        public string Message { get; set; }

        public HttpStatusCode HttpCode { get; set; }

        public string ErrorCode { get; set; }

        public bool IsSucceeded { get; set; }

        public object Data { get; set; }


        public static Response Succeed(HttpStatusCode httpCode, object data = default, string code = "", string message = "") => new Response
        {
            HttpCode = httpCode,
            Data = data,
            ErrorCode = code,
            Message = message,
            IsSucceeded = true
        };

        public static Response Fail(HttpStatusCode statusCode, string code, string message) => new Response
        {
            HttpCode = statusCode,
            ErrorCode = code,
            Message = message,
            IsSucceeded = false
        };
    }
}
