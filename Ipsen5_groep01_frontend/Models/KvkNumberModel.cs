namespace Ipsen5_groep01_frontend.Models
{
    public class KvkNumberModel
    {
        public Guid Id { get; set; } // primary key

        public Guid CandidateId { get; set; } // Foreign Key to Candidate

        public string KVKNumber { get; set; }
    }
}
