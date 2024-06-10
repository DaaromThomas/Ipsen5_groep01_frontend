namespace Ipsen5_groep01_frontend.Models
{
    public class BankAccountNumberModel
    {
        public Guid Id { get; set; } // primary key

        public Guid CandidateId { get; set; } // Foreign Key to Candidate

        public string AccountNumber { get; set; }
    }
}
