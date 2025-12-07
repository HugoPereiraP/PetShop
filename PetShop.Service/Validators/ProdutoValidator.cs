using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(p => p.Preco)
                .GreaterThan(0).WithMessage("O preço deve ser maior que zero.");

            RuleFor(p => p.Quantidade)
                .GreaterThanOrEqualTo(0);

            RuleFor(p => p.UnidadeVenda)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(p => p.IdGrupo)
                .GreaterThan(0);

            RuleFor(p => p.Estoque)
                .GreaterThanOrEqualTo(0);
        }
    }
}
