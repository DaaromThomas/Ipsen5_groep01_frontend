
using System.Text;
using Newtonsoft.Json;

namespace Ipsen5_groep01_frontend.Components.Services{
    public class FileUploadService{
     private readonly HttpClient _httpClient;


    public FileUploadService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        httpClient.BaseAddress = new Uri("http://localhost:5196/api/");
    }

public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
{
    // Creëer een MultipartFormDataContent object om het bestand te uploaden
    var formData = new MultipartFormDataContent();

    // Voeg het bestand toe aan de content
    formData.Add(new StreamContent(fileStream), "file", fileName);

    // Verstuur de gegevens naar de server
    var response = await _httpClient.PostAsync("BlobStorage/upload", formData);

    // Controleer of de server een succesvolle response heeft gegeven
    response.EnsureSuccessStatusCode();

    // Lees de response van de server en retourneer deze als een string
    return await response.Content.ReadAsStringAsync();
}


}
}