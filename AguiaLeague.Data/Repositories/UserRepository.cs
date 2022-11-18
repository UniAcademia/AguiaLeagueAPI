using AguiaLeague.Domain.Interfaces.Repositories;
using AguiaLeague.Domain.Models;

namespace AguiaLeague.Data.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AguiaLeagueContext context) : base(context) {}
    
    public User? ObterPorId(Guid id, string[]? includes = null)
    {
        return Obter(x => x.Id == id).FirstOrDefault();
    }
    
    public User? ObterPorId(ulong id, string[]? includes = null)
    {
        return Obter(x => x.Discord == id).FirstOrDefault();
    }
}