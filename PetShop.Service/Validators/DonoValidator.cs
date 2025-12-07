using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class DonoValidator : AbstractValidator<Dono>
    {
        public DonoValidator()
        {
            RuleFor(d => d.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(120);

            RuleFor(d => d.Email)
                .NotEmpty()
                .EmailAddress().WithMessage("O email informado é inválido.");

            RuleFor(d => d.Senha)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(4).WithMessage("A senha deve ter pelo menos 4 caracteres.");

            RuleFor(d => d.Telefone)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(d => d.Documento)
                .NotEmpty()
                .MaximumLength(20);

            RuleFor(d => d.IdCidade)
                .GreaterThan(0).WithMessage("A cidade deve ser informada.");
        }
    }
}
