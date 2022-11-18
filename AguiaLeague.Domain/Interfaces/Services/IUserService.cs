using AguiaLeague.CrossCutting.Interfaces;
using AguiaLeague.Domain.Models;
using FluentValidation.Results;

namespace AguiaLeague.Domain.Interfaces.Services;

public interface IUserService : IDisposable, IBaseScoped
{
    ValidationResult Adicionar(User user);

    User? ObterPorId(Guid id, string[]? includes = null);
    User? ObterPorId(ulong id, string[]? includes = null);
}