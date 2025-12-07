using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class GrupoValidator : AbstractValidator<Grupo>
    {
        public GrupoValidator()
        {
            RuleFor(g => g.Nome)
                .NotEmpty().WithMessage("O nome do grupo é obrigatório.")
                .MaximumLength(100);
        }
    }
}
