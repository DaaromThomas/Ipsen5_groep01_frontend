using Ipsen5_groep01_frontend.Models;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class DocumentenService
    {
        private List<Document> documenten = new List<Document>
        {
            new Document { UploadType = "Rijbewijs", DocumentType = "Pdf", Required = false },
            new Document { UploadType = "Taxipas", DocumentType = "Docx", Required = true},
            new Document { UploadType = "PO nummer", DocumentType = "Pdf", Required = true }
        };

        public Task<List<Document>> GetDocumentenAsync()
        {
            return Task.FromResult(documenten);
        }

        public void ToevoegenDocument(Document document)
        {
            documenten.Add(document);
        }

        public void VerwijderDocument(Document document)
        {
            documenten.Remove(document);
        }
    }
}
