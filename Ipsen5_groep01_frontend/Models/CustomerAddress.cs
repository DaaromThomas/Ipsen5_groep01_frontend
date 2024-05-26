using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class CustomerAddress
    {
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Huisnummer is verplicht")]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "Postcode is verplicht")]
        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Province { get; set; }
    }
}
