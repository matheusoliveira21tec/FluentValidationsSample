using FluentValidation;
using FluentValidationsSample.Models;

namespace FluentValidationsSample.Validators
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerModel>
    {
        public CreateCustomerValidator()
        {
            RuleFor(c => c.FullName)
                .NotEmpty()
                .Length(3, 100).WithMessage("FullName deve ter entre 3 e 100 caracteres");
            RuleFor(c => c.Document)
                .NotEmpty()
                .Length(10).WithMessage("Documente deve ter exatamente 10 caracteres");
            RuleFor(c => c.Birthday).LessThan(DateTime.Now).WithMessage("Data de aniversario deve ser anterior á hoje.");
            RuleFor(c => c.ReferralCode).NotEmpty().When(c => c.IsReferral);
        }
    }
}
