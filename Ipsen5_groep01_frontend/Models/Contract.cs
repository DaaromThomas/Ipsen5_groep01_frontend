namespace Ipsen5_groep01_frontend.Models
{
    public class Contract
    {
        public Guid id { get; set; } 

        public Guid candidateId { get; set; } 

        public Guid customerId { get; set; }

        public string status { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public double purchaseRate { get; set; }

        public double sellingRate { get; set; }

        public string paymentTerm { get; set; }

        public string feeParty { get; set; }

        public string jobDescription { get; set; }

        public string note { get; set; }

        public bool template { get; set; }

        public List<CandidateDocumentModel> candidateDocumentsDto { get; set; }

        public Contract()
        {
            if(candidateDocumentsDto == null)
            {
                candidateDocumentsDto = new List<CandidateDocumentModel>();
            }
        }

    }
}
