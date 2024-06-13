using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class KvkNumberModel
    {
        public Guid Id { get; set; } // primary key

        public Guid CandidateId { get; set; } // Foreign Key to Candidate

        [Required(ErrorMessage = "KVK-nummer is verplicht")]
        public string KVKNumber { get; set; }
    }
}
