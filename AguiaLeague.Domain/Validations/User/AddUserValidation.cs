using FluentValidation;

namespace AguiaLeague.Domain.Validations.User;

public class AddUserValidation : AbstractValidator<Models.User>
{
    public AddUserValidation()
    {
        RuleFor(x => x.Discord).NotEmpty().WithMessage("Erro desconhecido ao obter a conta do Discord.");
    }
}