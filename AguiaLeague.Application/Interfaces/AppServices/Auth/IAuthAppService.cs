using AguiaLeague.Application.DTOs;

namespace AguiaLeague.Application.Interfaces.AppServices.Auth;

public interface IAuthAppService : IDisposable
{
    Task<DiscordUserDto?> Autenticar(string code);
}