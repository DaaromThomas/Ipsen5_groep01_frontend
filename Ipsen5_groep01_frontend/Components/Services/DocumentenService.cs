namespace Ipsen5_groep01_frontend.Components.Services
{
	public class DocumentenService
	{
		private List<Document> documenten = new List<Document>
		{
			new Document { Naam = "Rijbewijs", Verplicht = true },
			new Document { Naam = "Taxipas", Verplicht = true },
			new Document { Naam = "PO ", Verplicht = true }
		};

		public List<Document> GetDocumenten()
		{
			return documenten;
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


