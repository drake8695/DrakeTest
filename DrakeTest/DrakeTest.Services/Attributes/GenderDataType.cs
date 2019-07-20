using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakeTest.Services.Attributes
{
    public class GenderDataType : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString() == "Male" || value.ToString() =="Female")
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Gender Field Must be Male or Female");
        }
    }
}
