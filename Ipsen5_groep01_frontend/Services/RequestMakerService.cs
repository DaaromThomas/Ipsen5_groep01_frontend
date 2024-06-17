using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
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

        public async Task<HttpResponseMessage> MakeRequest(HttpMethod method, string endpoint, HttpContent? content = null)
        {
            var url = $"{BaseUrl}/{endpoint}"; 
            var request = new HttpRequestMessage(method, url)
            {
                Content = content
            };

            return await _httpClient.SendAsync(request);
        }

        public async Task<HttpResponseMessage> MakePostRequest<T>(string endpoint, T data, string jwtToken)
        {
            var url = $"{BaseUrl}/{endpoint}"; 
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);
            
            return await _httpClient.PostAsync(url, content);
        }

        public async Task<HttpResponseMessage> MakePatchRequest<T>(string endpoint, T data)
        {
            var url = $"{BaseUrl}/{endpoint}";
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(json);

            return await _httpClient.PatchAsync(url, content);
        }
        
        public async Task<HttpResponseMessage> MakePutRequest<T>(string endpoint, T data)
        {
            var url = $"{BaseUrl}/{endpoint}";
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(json);

            return await _httpClient.PutAsync(url, content);
        }


        public async Task<HttpResponseMessage> MakeGetRequest(string endpoint)
        {
            var url = $"{BaseUrl}/{endpoint}";
            return await _httpClient.GetAsync(url);
        }

        

        public async Task<string> GetAddressInfoAsync(string postcode, string number)
        {
            var json = File.ReadAllText("apikey.json");
            var jsonDocument = JsonDocument.Parse(json);
            var apiKey = jsonDocument.RootElement.GetProperty("postal_code_api_key").GetString();


            var url = $"https://postcode.tech/api/v1/postcode/full?postcode={postcode}&number={number}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException($"Request failed with status code {response.StatusCode}");
            }
        }
    }
}
