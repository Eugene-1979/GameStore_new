using Data.Interfaces;
using GameStore.Data.Data;
using GameStore.Data.Interfaces;
using GameStore.Data.Repositories;
using System.Threading.Tasks;

namespace Data.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameStoreContext _context;


        private IGameRepository gameRepository;

        private IGenreRepository genreRepository;
        private IPlatformRepository platformRepository;
        private IGamePlatformRepository gamePlatformRepository;
        private IGameGenreRepository gameGenreRepository;

        public UnitOfWork(GameStoreContext context)
        {
            _context = context;
        }
     

        public IGameRepository GameRepository { get => gameRepository = gameRepository ?? new GameRepository(_context); }

        public IGenreRepository GenreRepository { get => genreRepository = genreRepository ?? new GenreRepository(_context); }

        public IPlatformRepository PlatformRepository { get => platformRepository = platformRepository ?? new PlatformRepository(_context); }

        public IGameGenreRepository GameGenreRepository { get => gameGenreRepository = gameGenreRepository ?? new GameGenreRepository(_context); }

        public IGamePlatformRepository GamePlatformRepository { get => gamePlatformRepository = gamePlatformRepository ?? new GamePlatformRepository(_context); }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }






}
