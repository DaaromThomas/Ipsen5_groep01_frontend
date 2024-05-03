using System.Threading.Tasks;
using System.Collections.Generic;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class DocumentenService
    {
        private List<Document> documenten = new List<Document>
        {
            new Document { Naam = "Rijbewijs", Verplicht = true, Extensie = ".pdf" },
            new Document { Naam = "Taxipas", Verplicht = true, Extensie = ".docx"},
            new Document { Naam = "PO nummer", Verplicht = true, Extensie = ".pdf" }
        };

        public Task<List<Document>> GetDocumentenAsync()
        {
            // Return a completed task with the list of documents
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

    public class Document
    {
        public string Naam { get; set; }
        public bool Verplicht { get; set; }
        public string Extensie { get; set; }
    }
}
