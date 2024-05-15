using Ipsen5_groep01_frontend.Models;

namespace Ipsen5_groep01_frontend.Services
{
    public class LeverancierDossierService
    {
        private List<Document> documents = new List<Document>{
        
            
        };

        public List<Document> getDocuments(){
            return this.documents;
        }
    }
}
