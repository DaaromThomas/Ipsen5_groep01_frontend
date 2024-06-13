using Ipsen5_groep01_frontend.Models;
using System.ComponentModel.DataAnnotations;

namespace Ipsen5_groep01_frontend.Services
{
    public class StepRequiredAttribute : ValidationAttribute
    {
        private readonly int[] _steps;

        public StepRequiredAttribute(params int[] steps)
        {
            _steps = steps;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (RegisterModel)validationContext.ObjectInstance;
            if (Array.Exists(_steps, step => step == model.CurrentStep) && string.IsNullOrEmpty(value?.ToString()))
            {
                return new ValidationResult(ErrorMessage ?? "Dit veld is verplicht.");
            }
            return ValidationResult.Success;
        }
    }
}
