using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PutPostAPI
{
    internal class HttpClientMethods
    {
        private readonly HttpClient client;
        public HttpClientMethods()
        {
            client = new HttpClient();
        }
        public async Task<string> SendRequestAsync(string method, string url, string json)
        {
            try
            {
                HttpContent content = null;

                if (json != null)
                {
                    content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                HttpResponseMessage response = null;

                switch (method.ToUpper())
                {
                    case "GET":
                        response = await client.GetAsync(url);
                        break;
                    case "POST":
                        response = await client.PostAsync(url, content);
                        break;
                    case "PUT":
                        response = await client.PutAsync(url, content);
                        break;
                    case "DELETE":
                        response = await client.DeleteAsync(url);
                        break;
                    default:
                        throw new ArgumentException($"Unsupported HTTP method: {method}");
                }

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                else
                {
                    return response.StatusCode.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message; 
            }
        }

    }
}
