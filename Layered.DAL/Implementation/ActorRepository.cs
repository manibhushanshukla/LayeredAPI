using Layered.DAL.Context;
using Layered.Domain.Entities;
using Layered.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Layered.DAL.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieDbContext context) : base(context)
        {
        }

        public IEnumerable<Actor> GetActorByMovies()
        {
            var actorsByMovies = _context.Actors.Include(u => u.Movies).ToList();
            return actorsByMovies;
        }
    }
}