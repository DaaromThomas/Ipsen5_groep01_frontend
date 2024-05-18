using System.Text;
using Ipsen5_groep01_frontend.Models;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class UploadTypeService
    {
        private readonly HttpClient httpClient;

        public UploadTypeService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:5196/api/");
            
        }
        private List<UploadType> documenten = new List<UploadType>
        {
            new UploadType { Type = "Rijbewijs", DocumentType = "Pdf", Required = false },
            new UploadType { Type = "Taxipas", DocumentType = "Docx", Required = true},
            new UploadType { Type = "PO nummer", DocumentType = "Pdf", Required = true }
        };

        public Task<List<UploadType>> GetDocumentenAsync()
        {
            return Task.FromResult(documenten);
        }

        public void ToevoegenDocument(UploadType document)
        {
            documenten.Add(document);
        }

        public void VerwijderDocument(UploadType document)
        {
            documenten.Remove(document);
        }
        public async Task ToevoegenDocumentAsync(UploadType uploadType)     
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(uploadType);

            Console.WriteLine("Verzonden JSON-gegevens naar backend:");
            Console.WriteLine(json);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("uploadtype/adduploadtype", content);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Document succesvol toegevoegd!");
            }
            else
            {
                Console.WriteLine("Er is een fout opgetreden bij het toevoegen van het document.");
                Console.WriteLine(response);
            }
        }
    }
}
