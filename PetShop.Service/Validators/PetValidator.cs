using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class PetValidator : AbstractValidator<Pet>
    {
        public PetValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O nome do pet é obrigatório.")
                .MaximumLength(100);

            RuleFor(p => p.Especie)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(p => p.Raca)
                .NotEmpty()
                .MaximumLength(60);

            RuleFor(p => p.IdDono)
                .GreaterThan(0).WithMessage("O dono deve ser informado.");

            RuleFor(p => p.Idade)
                .GreaterThanOrEqualTo(0);

            RuleFor(p => p.Peso)
                .GreaterThan(0);
        }
    }
}
