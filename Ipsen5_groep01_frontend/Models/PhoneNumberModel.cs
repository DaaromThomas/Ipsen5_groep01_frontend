namespace IPSEN5_Backend.Services.Dtos
{
    public class PhoneNumberModel
    {
        public Guid Id { get; set; } // primary key

        public Guid CandidateId { get; set; } // Foreign Key to Candidate

        public string Phonenumber { get; set; }
    }
}
