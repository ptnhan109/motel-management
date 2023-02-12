using Motel.Application.Services;
using Motel.Common;
using Motel.Service;
using Motel.Service.Entities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel.Application.Services
{
    public class HttpProvider : IHttpProvider
    {
        public Task<Response> GetAsync(WebRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task<TResponse> PostAsync<TResponse>(WebRequestModel request) where TResponse : class
        {
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Clear();
                        if (!IsAllowAnonymous(request.Url))
                        {
                            client.DefaultRequestHeaders.Add("Authorization", GetToken());
                        }

                        var content = new StringContent(request.BodyJson == null ? "" : request.BodyJson, Encoding.UTF8, "application/json");
                        var postTask = await client.PostAsync(request.Url, content);

                        var msg = postTask.Content.ReadAsStringAsync().Result;

                        var result = JsonConvert.DeserializeObject<Response>(msg);

                        return result.Data as TResponse;
                    }
                }
                catch
                {
                    return default;
                }
            }
        }

        public async Task<Response> PostAsync(WebRequestModel request)
        {
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Accept.Clear();
                        if (!IsAllowAnonymous(request.Url))
                        {
                            client.DefaultRequestHeaders.Add("Authorization", GetToken());
                        }
                        var content = new StringContent(request.BodyJson == null ? "" : request.BodyJson, Encoding.UTF8, "application/json");
                        var postTask = await client.PostAsync(request.Url, content);

                        var msg = postTask.Content.ReadAsStringAsync().Result;

                        return JsonConvert.DeserializeObject<Response>(msg);
                    }
                }
                catch (Exception ex)
                {
                    return default;
                }
            }
        }

        private bool IsAllowAnonymous(string endpoint)
        {
            var noAuthenUrls = new List<string>() { "auth" };
            foreach(var url in noAuthenUrls)
            {
                if (endpoint.ToLower().Contains(url.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        private string GetToken() => string.Empty;
    }
}
