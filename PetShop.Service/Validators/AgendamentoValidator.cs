using FluentValidation;
using PetshopStore.Domain.Entities;

namespace PetShop.Service.Validators
{
    public class AgendamentoValidator : AbstractValidator<Agendamento>
    {
        public AgendamentoValidator()
        {
            RuleFor(a => a.IdPet)
                .GreaterThan(0);

            RuleFor(a => a.IdServico)
                .GreaterThan(0);

            RuleFor(a => a.DataHora)
                .GreaterThan(DateTime.Now)
                .WithMessage("A data do agendamento não pode ser no passado.");

            RuleFor(a => a.ValorTotal)
                .GreaterThan(0);
        }
    }
}
