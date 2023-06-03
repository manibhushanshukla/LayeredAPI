using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Layered.DAL.Context;
using Layered.Domain.Repository;

namespace Layered.DAL.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        public MovieDbContext _context { get; }
        public UnitOfWork(MovieDbContext context)
        {
            _context = context;
            Actor = new ActorRepository(_context);
            Biography = new BiographyRepository(_context);
            Genre = new GenreRepository(_context);
            Movie = new MovieRepository(_context);
        }

        public IActorRepository Actor { get; private set; }

        public IBiographyRepository Biography { get; private set; }

        public IGenreRepository Genre { get; private set; }

        public IMovieRepository Movie { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}