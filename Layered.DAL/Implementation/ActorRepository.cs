using Layered.DAL.Context;
using Layered.Domain.Entities;
using Layered.Domain.Repository;

namespace Layered.DAL.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieDbContext context) : base(context)
        {
        }
    }
}