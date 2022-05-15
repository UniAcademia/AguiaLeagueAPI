using AguiaLeague.Application.DTOs;
using AguiaLeague.Domain.Interfaces.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace AguiaLeague.Api.Controllers.Auth
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Autentica o usuário pelo Discord.
        /// </summary>
        /// <param name="code">Código gerado pela API do Discord.</param>
        /// <response code="200">Retorna o objeto do usuário do Discord.</response>
        /// <response code="400">Ocorreu algum erro ao consultar a API do Discord.</response>
        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DiscordUserDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        public async Task<IActionResult> Autenticar(string code)
        {
            var result = await _authService.Autenticar(code);
            if (result == null) return BadRequest();

            return Ok(result);
        }
    }
}
