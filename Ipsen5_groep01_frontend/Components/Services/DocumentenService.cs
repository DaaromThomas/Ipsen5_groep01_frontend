using System.Threading.Tasks;
using System.Collections.Generic;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class DocumentenService
    {
        private List<DocumentMarcel> documenten = new List<DocumentMarcel>
        {
            new DocumentMarcel { Naam = "Rijbewijs", Verplicht = true, Extensie = ".pdf" },
            new DocumentMarcel { Naam = "Taxipas", Verplicht = true, Extensie = ".docx"},
            new DocumentMarcel { Naam = "PO nummer", Verplicht = true, Extensie = ".pdf" }
        };

        public Task<List<DocumentMarcel>> GetDocumentenAsync()
        {
            return Task.FromResult(documenten);
        }

        public void ToevoegenDocument(DocumentMarcel document)
        {
            documenten.Add(document);
        }

        public void VerwijderDocument(DocumentMarcel document)
        {
            documenten.Remove(document);
        }
    }

    public class DocumentMarcel
    {
        public string Naam { get; set; }
        public bool Verplicht { get; set; }
        public string Extensie { get; set; }
    }
}
