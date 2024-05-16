using System.Threading.Tasks;
using System.Collections.Generic;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class DocumentenService
    {
        private List<AddDocument> documenten = new List<AddDocument>
        {
            new AddDocument { UploadType = "Rijbewijs", DocumentType = "Pdf", Required = false },
            new AddDocument { UploadType = "Taxipas", DocumentType = "Docx", Required = true},
            new AddDocument { UploadType = "PO nummer", DocumentType = "Pdf", Required = true }
        };

        public Task<List<AddDocument>> GetDocumentenAsync()
        {
            return Task.FromResult(documenten);
        }

        public void ToevoegenDocument(AddDocument document)
        {
            documenten.Add(document);
        }

        public void VerwijderDocument(AddDocument document)
        {
            documenten.Remove(document);
        }
    }

    public class AddDocument
    {
        public string UploadType { get; set; }
        public string DocumentType { get; set; }
        public bool Required { get; set; }
    }
}
