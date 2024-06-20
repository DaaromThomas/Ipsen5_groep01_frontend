using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class Candidate
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.Today;

        [RegularExpression("^[0-9]*$", ErrorMessage = "BSN mag alleen cijfers bevatten")]
        public string? BSN { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public BankAccountNumberModel BankAccountNumber { get; set; }

        public KvkNumberModel KvkNumber { get; set; }

        public NawModel Naw { get; set; }

        public PhoneNumberModel PhoneNumber { get; set; }

        public VatNumberModel VatNumber { get; set; }

        public List<CandidateAddressModel> CandidateAddress { get; set; }
    }
}