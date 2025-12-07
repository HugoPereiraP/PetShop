using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class ServicoValidator : AbstractValidator<Servico>
    {
        public ServicoValidator()
        {
            RuleFor(s => s.Nome)
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(s => s.Descricao)
                .MaximumLength(300);

            RuleFor(s => s.Preco)
                .GreaterThan(0).WithMessage("O preço deve ser maior que zero.");
        }
    }
}
