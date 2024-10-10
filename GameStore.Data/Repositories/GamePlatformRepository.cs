using GameStore.Data.Data;
using GameStore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Repositories
{
    public class GamePlatformRepository : IGamePlatformRepository
        {
        private readonly GameStoreContext _context;

        public GamePlatformRepository(GameStoreContext context)
            {
            _context = context;
            }
        public Task AddAsync(Entities.GamePlatform entity)
            {
            throw new NotImplementedException();
            }

        public void Delete(Entities.GamePlatform entity)
            {
            throw new NotImplementedException();
            }

        public Task DeleteByIdAsync(Guid id)
            {
            throw new NotImplementedException();
            }

        public Task<IEnumerable<Entities.GamePlatform>> GetAllAsync()
            {
            throw new NotImplementedException();
            }

        public Task<Entities.GamePlatform> GetByIdAsync(Guid id)
            {
            throw new NotImplementedException();
            }

        public Task Update(Entities.GamePlatform entity)
            {
            throw new NotImplementedException();
            }
        }
    }
