﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace Ipsen5_groep01_frontend.Models
{
    public class SignInModel
    {
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [JsonIgnore]
        public string Role {  get; set; }
    }
}