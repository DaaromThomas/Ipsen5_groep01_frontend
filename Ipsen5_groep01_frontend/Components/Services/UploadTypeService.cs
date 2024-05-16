using Ipsen5_groep01_frontend.Models;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class UploadTypeService
    {
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
    }
}
