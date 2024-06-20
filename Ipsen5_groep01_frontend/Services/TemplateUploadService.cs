using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Forms;

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

        public async Task UploadAllDocuments()
        {
            foreach (var document in _documents)
            {
                try
                {
                    
                }
                finally
                {
                    document.Dispose();
                }
            }
        }


        public async Task<string> _uploadDocument(InputFileChangeEventArgs e, string uploadTypeName)
        {
            var file = e.File;
            if (file == null)
            {
                return "";
            }
            using (var memoryStream = new MemoryStream())
            {
                await file.OpenReadStream().CopyToAsync(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);

                var formData = new MultipartFormDataContent();
                formData.Add(new StreamContent(memoryStream), "file", file.Name);
                formData.Add(new StringContent(_customerId.ToString()), "customerId");
                formData.Add(new StringContent(uploadTypeName), "uploadTypeName");

                var response = await _httpClient.PostAsync($"BlobStorage/uploadTemplate/{_customerId}/{uploadTypeName}", formData);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }



        public async Task AddUploadedDocumentToList(InputFileChangeEventArgs e, string uploadTypeName)
        {
            var file = e.File;
            if (file == null)
            {
                return;
            }

            var memoryStream = new MemoryStream();
            await file.OpenReadStream().CopyToAsync(memoryStream);
            memoryStream.Seek(0, SeekOrigin.Begin);

            var binaryDocument = new BinaryDocument(memoryStream, file.Name, uploadTypeName);
            AddDocument(binaryDocument);
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

    public class BinaryDocument : IDisposable
    {
        private Stream _stream;
        private string _fileName;
        private string _uploadTypeName;
        private bool _disposed;

        public BinaryDocument() { }

        public BinaryDocument(Stream stream, string name, string uploadTypeName)
        {
            _stream = stream;
            _fileName = name;
            _uploadTypeName = uploadTypeName;
        }

        public string GetFileName() => _fileName;
        public Stream GetStream() => _stream;
        public string GetUploadTypeName() => _uploadTypeName;

        public void SetFileName(string name) => _fileName = name;
        public void SetStream(Stream stream) => _stream = stream;
        public void SetUploadTypeName(string uploadTypeName) => _uploadTypeName = uploadTypeName;

        public void Dispose()
        {
            if (!_disposed)
            {
                _stream?.Dispose();
                _disposed = true;
            }
        }
    }



}