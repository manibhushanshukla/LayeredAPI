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
            ActorRepository = new ActorRepository(_context);
            BiographyRepository = new BiographyRepository(_context);
            GenreRepository = new GenreRepository(_context);
            MovieRepository = new MovieRepository(_context);
        }

        public IActorRepository ActorRepository { get; private set; }

        public IBiographyRepository BiographyRepository { get; private set; }

        public IGenreRepository GenreRepository { get; private set; }

        public IMovieRepository MovieRepository { get; private set; }

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