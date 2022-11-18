using AguiaLeague.Domain.Models;

namespace AguiaLeague.Domain.Interfaces.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    User? ObterPorId(Guid id, string[]? includes = null);
}