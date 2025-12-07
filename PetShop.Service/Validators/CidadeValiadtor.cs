using FluentValidation;

using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {
        public CidadeValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome da cidade é obrigatório.")
                .MaximumLength(100).WithMessage("O nome da cidade deve ter no máximo 100 caracteres.");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("O estado é obrigatório.")
                .MaximumLength(2).WithMessage("O estado deve ter apenas 2 caracteres (UF).");
        }
    }
}
