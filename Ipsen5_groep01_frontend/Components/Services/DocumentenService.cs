 using System.Threading.Tasks; // Import the necessary namespace for Task

namespace Ipsen5_groep01_frontend.Components.Services
{
	public class DocumentenService
	{
		private List<Document> documenten = new List<Document>
		{
			new Document { Naam = "Rijbewijs", Verplicht = true },
			new Document { Naam = "Taxipas", Verplicht = true },
			new Document { Naam = "PO", Verplicht = true }
		};

		// Modify the return type to Task<List<Document>>
		public Task<List<Document>> GetDocumentenAsync()
		{
			// Return a completed task with the list of documents
			return Task.FromResult(documenten);
		}

		public void ToevoegenDocument(Document document)
		{
			documenten.Add(document);
		}
	}

	public class Document
	{
		public string Naam { get; set; }
		public bool Verplicht { get; set; }
	}
}
