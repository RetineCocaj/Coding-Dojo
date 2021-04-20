using System;
using System.ComponentModel.DataAnnotations;
namespace HealthCareCost.Models
{
    public class AgeValidator : ValidationAttribute
    {
        public int _minimumAge;
        public AgeValidator(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date = (DateTime)value;
            if (date.AddYears(_minimumAge) < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "You must be at least 18 year old.");
        }
    }
}
