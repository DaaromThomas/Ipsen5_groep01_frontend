namespace Ipsen5_groep01_frontend.Models
{
    public class Contract
    {
        public Guid Id { get; set; } 

        public Guid CandidateId { get; set; } 

        public Guid CustomerId { get; set; }

        public string Status { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double PurchaseRate { get; set; }

        public double SellingRate { get; set; }

        public string PaymentTerm { get; set; }

        public string FeeParty { get; set; }

        public string JobDescription { get; set; }

        public string Note { get; set; }

        public bool Template { get; set; }

        public List<CandidateDocumentModel> CandidateDocumentsDto { get; set; }

        public Contract()
        {
            if(CandidateDocumentsDto == null)
            {
                CandidateDocumentsDto = new List<CandidateDocumentModel>();
            }
        }

        public override string ToString()
    {
        return $"Id: {Id}, CandidateId: {CandidateId}, CustomerId: {CustomerId}, Status: {Status}, StartDate: {StartDate}, EndDate: {EndDate}, PurchaseRate: {PurchaseRate}, SellingRate: {SellingRate}, PaymentTerm: {PaymentTerm}, FeeParty: {FeeParty}, JobDescription: {JobDescription}, Note: {Note}, Template: {Template}, CandidateDocumentsDto: {string.Join(", ", CandidateDocumentsDto)}";
    }

    }
}
