using System.Text;
using Newtonsoft.Json;
using System.Net.Http;

namespace Ipsen5_groep01_frontend.Services{
    public class TemplateUploadService{
        private List<BinaryDocument> _documents = [];
        private Guid _customerId;
        private readonly HttpClient _httpClient;

        public TemplateUploadService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            httpClient.BaseAddress = new Uri("http://localhost:5196/api/");
        }

        public async Task UploadAllDocuments(){
            foreach(BinaryDocument document in _documents){
                _uploadDocument(document);
            }
        }

        private async Task<string> _uploadDocument(BinaryDocument document){
            var formData = new MultipartFormDataContent();
            formData.Add(new StreamContent(document.GetStream()), "file", document.GetFileName());

            Console.WriteLine(formData);
            var response = await _httpClient.PostAsync($"BlobStorage/uploadTemplate/{_customerId}/{document.GetUploadTypeName()}", formData);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public void ClearDocuments(){
            _documents.Clear();
        }

        public void AddDocument(BinaryDocument document){
            _documents.Add(document);
        }

        public void RemoveDocument(BinaryDocument document){
            _documents.Remove(document);
        }

        public List<BinaryDocument> GetAllDocuments(){
            return _documents;
        }

        public void SetCustomerId(Guid customerId){
            _customerId = customerId;
        }

        public Guid GetCustomerId()
        {
        return _customerId;
        }

    }

    public class BinaryDocument{
        private Stream _stream;
        private string _fileName;
        private Guid _uploadTypeName;

        public BinaryDocument(Stream stream, string name, Guid uploadTypeName){
            _stream = stream;
            _fileName = name;
            _uploadTypeName = uploadTypeName;
        }

        public string GetFileName(){
            return _fileName;
        }

        public Stream GetStream(){
            return _stream;
        }

        public Guid GetUploadTypeName(){
            return _uploadTypeName;
        }

        public void SetFileName(string name){
            _fileName = name;
        }

        public void SetStream(Stream stream){
            _stream = stream;
        }

        public void SetUploadTypeName(Guid uploadTypeName){
            _uploadTypeName = uploadTypeName;
        }
    }

}