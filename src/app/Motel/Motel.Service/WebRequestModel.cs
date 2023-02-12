using Newtonsoft.Json;
using System.Collections.Specialized;

namespace Motel.Service
{
    public class WebRequestModel
    {
        public string Url { get; set; } = string.Empty;
        public HttpMethod Method { get; set; } = HttpMethod.Get;
        public string ContentType { get; set; } = string.Empty;
        public string BodyJson { get; set; } = string.Empty;

        public WebRequestModel(string url, HttpMethod method, object request)
        {
            Url = url;
            Method = method;
            BodyJson = JsonConvert.SerializeObject(request);
            ContentType = "application/json";
        }
    }
}