using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class UniqueCampanyAttribute: ValidationAttribute
    {
            protected override ValidationResult? IsValid
                (object? value, ValidationContext validationContext)
            {
                Context context = new Context();
                string name = value.ToString();
                Campany campany=context.Companys

               .FirstOrDefault(x => x.Name == name  );
                if (campany == null)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("Name Already Found");
            }


        }
    }
