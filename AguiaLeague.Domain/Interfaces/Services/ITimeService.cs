using AguiaLeague.Domain.Models;
using FluentValidation.Results;

namespace AguiaLeague.Domain.Interfaces.Services;

public interface ITimeService : IDisposable, IBaseScoped
{
    ValidationResult Adicionar(Time time);

    Time? ObterPorId(Guid id, string[]? includes = null);
}