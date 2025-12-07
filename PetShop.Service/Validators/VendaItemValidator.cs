using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class VendaItemValidator : AbstractValidator<VendaItem>
    {
        public VendaItemValidator()
        {
            RuleFor(vi => vi.IdProduto)
                .GreaterThan(0);

            RuleFor(vi => vi.IdVenda)
                .GreaterThan(0);

            RuleFor(vi => vi.Quantidade)
                .GreaterThan(0).WithMessage("A quantidade deve ser maior que zero.");

            RuleFor(vi => vi.ValorUnitario)
                .GreaterThan(0);
        }
    }
}
