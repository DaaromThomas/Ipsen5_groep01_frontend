using Ipsen5_groep01_frontend.Models;

namespace Ipsen5_groep01_frontend.Components.Services
{
    public class DocumentenService
    {
        private List<Document> documenten = new List<Document>
        {
            new Document
            {
                Id = "1",
                Name = "Invoice001",
                UploadType = "Invoice",
                DocumentPath = "/documents/invoice001.pdf",
                Status = "Goedgekeurd",
                CreatedDate = DateTime.Now.AddDays(-10),
                UpdatedDate = DateTime.Now.AddDays(-5),
                CreatedBy = "John Doe",
                Required = true,
                Extention = ".pdf"
            },
            new Document
            {
                Id = "2",
                Name = "Contract002",
                UploadType = "Contract",
                DocumentPath = "/documents/contract002.pdf",
                Status = "Wachten op beoordeling",
                CreatedDate = DateTime.Now.AddDays(-15),
                UpdatedDate = DateTime.Now.AddDays(-10),
                CreatedBy = "Jane Smith",
                Required = true,
                Extention = ".pdf"
            },
            new Document
            {
                Id = "3",
                Name = "Proposal003",
                UploadType = "Proposal",
                DocumentPath = "/documents/proposal003.pdf",
                Status = "Afgekeurd",
                CreatedDate = DateTime.Now.AddDays(-20),
                UpdatedDate = DateTime.Now.AddDays(-15),
                CreatedBy = "Alice Johnson",
                Required = true,
                Extention = ".pdf"
            },
            new Document
            {
                Id = "4",
                Name = "Delivery004",
                UploadType = "Delivery",
                DocumentPath = "/documents/delivery004.pdf",
                Status = "Nog op te leveren",
                CreatedDate = DateTime.Now.AddDays(-25),
                UpdatedDate = DateTime.Now.AddDays(-20),
                CreatedBy = "Bob Williams",
                Required = true,
                Extention = ".pdf"
            }  
        };

        public List<Document> GetDocumentenAsync()
        {
            return this.documenten;
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
