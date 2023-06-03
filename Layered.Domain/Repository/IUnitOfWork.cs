namespace Layered.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository ActorRepository { get; }
        IBiographyRepository BiographyRepository { get; }
        IGenreRepository GenreRepository { get; }
        IMovieRepository MovieRepository { get; }
        int Save();

    }
}
