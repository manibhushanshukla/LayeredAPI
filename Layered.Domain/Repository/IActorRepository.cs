using Layered.Domain.Entities;

namespace Layered.Domain.Repository
{
    public interface IActorRepository:IGenericRepository<Actor>
    {
        IEnumerable<Actor> GetActorByMovies();
    }
}