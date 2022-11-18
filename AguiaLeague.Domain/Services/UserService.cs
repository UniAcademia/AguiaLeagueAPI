using AguiaLeague.Domain.Interfaces.Repositories;
using AguiaLeague.Domain.Interfaces.Services;
using AguiaLeague.Domain.Models;
using AguiaLeague.Domain.Validations.Time;
using FluentValidation.Results;

namespace AguiaLeague.Domain.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public ValidationResult Adicionar(User user)
    {
        var resultadoValidacao = new AddUserValidation().Validate(user);
        if (resultadoValidacao.IsValid)
            _userRepository.Adicionar(user);

        return resultadoValidacao;
    }

    public User? ObterPorId(Guid id, string[]? includes = null)
    {
        return _userRepository.ObterPorId(id, includes);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
using AguiaLeague.Domain.Interfaces.Repositories;
using AguiaLeague.Domain.Interfaces.Services;
using AguiaLeague.Domain.Models;
using AguiaLeague.Domain.Validations.Time;
using FluentValidation.Results;

namespace AguiaLeague.Domain.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public ValidationResult Adicionar(User user)
    {
        var resultadoValidacao = new AddUserValidation().Validate(user);
        if (resultadoValidacao.IsValid)
            _userRepository.Adicionar(user);

        return resultadoValidacao;
    }

    public User? ObterPorId(Guid id, string[]? includes = null)
    {
        return _userRepository.ObterPorId(id, includes);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}