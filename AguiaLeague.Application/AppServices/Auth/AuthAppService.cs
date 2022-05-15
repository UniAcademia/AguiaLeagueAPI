using AguiaLeague.Application.DTOs;
using AguiaLeague.Application.Interfaces.AppServices.Auth;
using AguiaLeague.Domain.Interfaces.Services.Auth;
using AutoMapper;

namespace AguiaLeague.Application.AppServices.Auth;

public class AuthAppService : BaseAppService, IAuthAppService
{
    private readonly IAuthService _authService;

    public AuthAppService(IMapper mapper,
                          IAuthService authService) : base(mapper)
    {
        _authService = authService;
    }

    public async Task<DiscordUserDto?> Autenticar(string code)
        => Mapper.Map<DiscordUserDto?>(await _authService.Autenticar(code));

    public void Dispose()
    {
        _authService.Dispose();
        GC.SuppressFinalize(this);
    }
}