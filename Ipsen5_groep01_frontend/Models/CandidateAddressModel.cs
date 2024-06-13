using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class CandidateAddressModel
    {
        public Guid Id { get; set; } // primary key
        [Required(ErrorMessage = "Straatnaam is verplicht")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Huisnummer is verplicht")]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "Postcode is verplicht")]
        public string PostalCode { get; set; }

        public string Country { get; set; }

        [Required(ErrorMessage = "Provincie is verplicht")]
        public string Province { get; set; }
    }
}
