using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Bedrijfsnaam is verplicht")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "KvK-nummer is verplicht")]
        [MaxLength(8, ErrorMessage = "KvK-nummer mag maximaal 8 tekens bevatten")]
        public string? KVK { get; set; }

        [Required(ErrorMessage = "BTW-nummer is verplicht")]
        public string? VAT { get; set; }

        [Required(ErrorMessage = "Bankrekeningnummer is verplicht")]
        public string? BankAccountNumber { get; set; }

        [EmailAddress(ErrorMessage = "Ongeldige email, voorbeeld@email.com")]
        [Required(ErrorMessage = "E-mailadres is verplicht")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Ongeldige Telefoonnummer, 0612345678")]
        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        public string? PhoneNumber { get; set; }

        public bool Disabled { get; set; }

        public CustomerAddress CustomerAddressDto { get; set; }

        public Customer()
        {
            CustomerAddressDto = new CustomerAddress();
        }
    }
}
