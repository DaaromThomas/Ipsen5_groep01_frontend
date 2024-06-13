﻿using Ipsen5_groep01_frontend.Services;
using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Models
{
    public class RegisterModel
    {
        public Guid Id { get; set; }
        public int CurrentStep { get; set; }


        //[StepRequired(2, ErrorMessage = "Voornaam is verplicht")]
        public string FirstName { get; set; }

        //[StepRequired(2, ErrorMessage = "Achternaam is verplicht")]
        public string LastName { get; set; }


        //[StepRequired(1, ErrorMessage = "Bevestig wachtwoord is verplicht")]
        [Compare("Password", ErrorMessage = "Wachtwoorden komen niet overeen")]
        public string ConfirmPassword { get; set; }

        //[StepRequired(1, ErrorMessage = "Wachtwoord is verplicht")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d{3,})(?=.*[^a-zA-Z\d]).{9,}$",
        ErrorMessage = "Wachtwoord moet minimaal 5 letters waarvan 1 hoofdletter, 1 teken en 3 cijfers bevatten.")]
        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Guid? CandidateId { get; set; }

        public string? UserName { get; set; }

        public string? PhoneNumber { get; set; }

        public bool IsDisabled { get; set; }

        public string? Role { get; set; }

        [Required(ErrorMessage = "Email is verplicht")]
        [EmailAddress(ErrorMessage = "Ongeldige email")]
        public string Email { get; set; }

        public Candidate? CandidateDto { get; set; }
    }
}
