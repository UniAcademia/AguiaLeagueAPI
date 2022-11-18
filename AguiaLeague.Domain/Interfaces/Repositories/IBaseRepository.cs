using System.Linq.Expressions;
using AguiaLeague.CrossCutting.Interfaces;

namespace AguiaLeague.Domain.Interfaces.Repositories;

public interface IBaseRepository<T> : IBaseScoped
{
    bool Adicionar(T obj);
    IEnumerable<T> Obter(Expression<Func<T, bool>> expressaoLambda, string[]? includes = null);
}