using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ipsen5_groep01_frontend.Services
{
    public class RequestMakerService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:5196/api"; 

        public RequestMakerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> MakeRequest(HttpMethod method, string endpoint, HttpContent content = null)
        {
            var url = $"{BaseUrl}/{endpoint}"; 
            var request = new HttpRequestMessage(method, url)
            {
                Content = content
            };

            return await _httpClient.SendAsync(request);
        }

        public async Task<HttpResponseMessage> MakePostRequest<T>(string endpoint, T data)
        {
            var url = $"{BaseUrl}/{endpoint}"; 
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await _httpClient.PostAsync(url, content);
        }

        public async Task<HttpResponseMessage> MakeGetRequest(string endpoint)
        {
            var url = $"{BaseUrl}/{endpoint}";
            return await _httpClient.GetAsync(url);
        }
    }
}
