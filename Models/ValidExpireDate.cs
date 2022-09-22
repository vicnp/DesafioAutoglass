using System.ComponentModel.DataAnnotations;
namespace Autoglass.Models
{
    public class ValidExpireDate: ValidationAttribute
    {
        protected override ValidationResult
                IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.Produto)validationContext.ObjectInstance;
            DateTime _fabrica = Convert.ToDateTime(model.Frabricacao);
            DateTime _validade = Convert.ToDateTime(model.validade);

            if (_validade > _fabrica)
            {
                return ValidationResult.Success;
            }
            else if (_validade < _fabrica)
            {
                return new ValidationResult
                    ("Data de validade não pode ser menor que data de fabricação.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }



    }
}
