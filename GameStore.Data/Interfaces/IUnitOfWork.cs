

using GameStore.Data.Interfaces;

namespace Data.Interfaces
{
    public interface IUnitOfWork
    {
        IGameRepository GameRepository { get; }

        IGenreRepository GenreRepository { get; }

        IPlatformRepository PlatformRepository { get; }

        IGamePlatformRepository GamePlatformRepository { get; }

        IGameGenreRepository GameGenreRepository { get; }

        Task SaveAsync();
    }
}
