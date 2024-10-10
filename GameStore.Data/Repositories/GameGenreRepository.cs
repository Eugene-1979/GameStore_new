using GameStore.Data.Data;
using GameStore.Data.Entities;
using GameStore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Repositories
{
    public class GameGenreRepository : IGameGenreRepository
        {

        private readonly GameStoreContext _context;

        public GameGenreRepository (GameStoreContext context)
            {
            _context = context;
            }


        public async Task AddAsync(GameGenre entity)=>await _context.GameGenres.AddAsync(entity);

        public void Delete(GameGenre entity)
            {
           

            throw new NotImplementedException();
            }

        public Task DeleteByIdAsync(Guid id)
            {
            throw new NotImplementedException();
            }

        public Task<IEnumerable<GameGenre>> GetAllAsync()
            {
            throw new NotImplementedException();
            }

        public Task<GameGenre> GetByIdAsync(Guid id)
            {
            throw new NotImplementedException();
            }

        public Task Update(GameGenre entity)
            {
            throw new NotImplementedException();
            }
        }
    }
