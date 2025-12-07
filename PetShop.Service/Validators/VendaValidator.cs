using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class VendaValidator : AbstractValidator<Venda>
    {
        public VendaValidator()
        {
            RuleFor(v => v.IdDono)
                .GreaterThan(0);

            RuleFor(v => v.IdUsuario)
                .GreaterThan(0);

            RuleFor(v => v.ValorTotal)
                .GreaterThan(0);

            RuleFor(v => v.Data)
                .NotEmpty();
        }
    }
}
