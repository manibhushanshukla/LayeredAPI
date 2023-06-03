using Layered.DAL.Context;
using Layered.Domain.Entities;
using Layered.Domain.Repository;

namespace Layered.DAL.Implementation
{
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(MovieDbContext context) : base(context)
        {
        }
    }
}