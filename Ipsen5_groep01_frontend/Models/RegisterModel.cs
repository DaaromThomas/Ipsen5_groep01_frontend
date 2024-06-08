using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class RegisterModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Guid? CandidateId { get; set; }

        public string? UserName { get; set; }

        public string? PhoneNumber { get; set; }

        public bool IsDisabled { get; set; }

        public string? Role { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public Candidate? CandidateDto { get; set; }
    }
}
