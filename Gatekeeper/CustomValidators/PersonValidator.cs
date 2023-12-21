using System.ComponentModel.DataAnnotations;

namespace Gatekeeper.CustomValidators
{
    public class PersonValidator : ValidationAttribute
    {

        public string Type { get; set; }

        public PersonValidator(string type)
        {
            Type = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value == null || value.ToString().Length == 0)
            {
                return new ValidationResult(Type + $" must not be null");
                
            }
            else
            {
                return null;
            }
            
        }
    }
}
