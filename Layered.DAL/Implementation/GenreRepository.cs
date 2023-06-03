using Layered.DAL.Context;
using Layered.Domain.Entities;
using Layered.Domain.Repository;

namespace Layered.DAL.Implementation
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MovieDbContext context) : base(context)
        {
        }
    }
}