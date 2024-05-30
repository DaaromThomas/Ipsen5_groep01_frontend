
using System.Text;
using Newtonsoft.Json;

namespace Ipsen5_groep01_frontend.Services
{
    public class FileUploadService
    {
        private readonly HttpClient _httpClient;


        public FileUploadService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            httpClient.BaseAddress = new Uri("http://localhost:5196/api/");
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            var formData = new MultipartFormDataContent();
            formData.Add(new StreamContent(fileStream), "file", fileName);

            var response = await _httpClient.PostAsync("BlobStorage/upload", formData);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }


    }
}