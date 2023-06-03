using Layered.DAL.Context;
using Layered.Domain.Entities;
using Layered.Domain.Repository;

namespace Layered.DAL.Implementation
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieDbContext context) : base(context)
        {
        }
    }
}