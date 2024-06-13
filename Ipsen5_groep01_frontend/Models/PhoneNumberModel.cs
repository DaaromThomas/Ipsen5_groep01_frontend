namespace Ipsen5_groep01_frontend.Models
{
    public class PhoneNumberModel
    {
        public Guid Id { get; set; } // primary key

        public Guid CandidateId { get; set; } // Foreign Key to Candidate

        public string Phonenumber { get; set; }
    }
}
