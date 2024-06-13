using System.ComponentModel.DataAnnotations;


namespace Ipsen5_groep01_frontend.Models
{
    public class SignInModel
    {
        [EmailAddress(ErrorMessage = "ongeldige email adres")]
        [Required(ErrorMessage = "Email is verplicht")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht")]
        public string Password { get; set; }
    }
}
