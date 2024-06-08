namespace IPSEN5_Backend.Services.Dtos
{
    public class NawModel
    {
        public Guid Id { get; set; } // primary key

        public Guid CandidateId { get; set; } // Foreign Key to Candidate

        public string NAW { get; set; }
    }
}
