using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class CustomerAddress
    {

        public Guid Id { get; set; }
        public string? StreetName { get; set; }

        [Required(ErrorMessage = "Huisnummer is verplicht")]
        public string? HouseNumber { get; set; }

        [Required(ErrorMessage = "Postcode is verplicht")]
        //[RegularExpression(@"^\d{4} \w{2}$", ErrorMessage = "Ongeldige postcode, 1234 AB")]
        public string? PostalCode { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public string? Province { get; set; }
    }
}
