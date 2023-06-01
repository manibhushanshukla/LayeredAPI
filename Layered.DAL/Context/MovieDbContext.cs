using Layered.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Layered.DAL.Context
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FirstName = "Mani", LastName = "Shukla", },
                new Actor { Id = 2, FirstName = "Jyoti", LastName = "Shukla", },
                new Actor { Id = 3, FirstName = "Anshß", LastName = "Shukla", }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Dosti", Description = "Test", ActorId = 1 },
                 new Movie { Id = 2, Name = "Rog", Description = "Test", ActorId = 2 },
                 new Movie { Id = 3, Name = "Ek Rista", Description = "Test", ActorId = 3 }
            );
        }
    }
}