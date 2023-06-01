namespace Layered.Domain.Repository
{
    interface IUnitOfWork : IDisposable
    {
        IActorRepository ActorRepository { get; }  
         IBiographyRepository BiographyRepository { get; }
         IGenreRepository GenreRepository { get;}
         IMovieRepository MovieRepository { get; }
         int Save();

    }
}
