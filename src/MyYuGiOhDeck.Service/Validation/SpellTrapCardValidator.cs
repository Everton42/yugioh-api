using FluentValidation;
using MyYuGiOhDeck.Domain.Entities;
using System;

namespace MyYuGiOhDeck.Service.Validation
{
    public class SpellTrapCardValidator : AbstractValidator<SpellTrapCard>
    {
        public SpellTrapCardValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não pode ser nulo.");
                    });

            RuleFor(c => c.Id)
                    .NotEmpty().WithMessage("O Id é obrigatório.")
                    .NotNull().WithMessage("O Id é obrigatório.");

            RuleFor(c => c.Name)
                    .NotEmpty().WithMessage("O Nome é obrigatório.")
                    .NotNull().WithMessage("O Nome é obrigatório.");

            RuleFor(c => c.Description)
                    .NotEmpty().WithMessage("A Descrição é obrigatório.")
                    .NotNull().WithMessage("A Descrição é obrigatório.");

            RuleFor(c => c.Type)
                    .NotEmpty().WithMessage("O Tipo é obrigatório.")
                    .NotNull().WithMessage("O Tipo é obrigatório.");

            RuleFor(c => c.Race)
                    .NotEmpty().WithMessage("A Raça é obrigatória.")
                    .NotNull().WithMessage("A Raça é obrigatória.");
        }
    }
}
