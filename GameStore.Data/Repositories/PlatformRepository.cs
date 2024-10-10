using GameStore.Data.Data;
using GameStore.Data.Entities;
using GameStore.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Repositories
{
    public class PlatformRepository : IPlatformRepository
        {
        private readonly GameStoreContext _context;

        public PlatformRepository(GameStoreContext context)
            {
            _context = context;
            }
        public async Task AddAsync(Platform entity)=>await _context.Platforms.AddAsync(entity);

        public async void Delete(Platform entity)
            {
            var  platform = await _context.Platforms.FirstOrDefaultAsync(q => q.Id == entity.Id);
            _context.Platforms.Remove(platform);
            }

        public async Task DeleteByIdAsync(Guid id)
            {
            var platform = await _context.Platforms.FirstOrDefaultAsync(q => q.Id == id);
            _context.Platforms.Remove(platform);
            }

        public async Task<IEnumerable<Platform>> GetAllAsync() => await _context.Platforms.ToListAsync();


        public async Task<Platform> GetByIdAsync(Guid id) => await _context.Platforms.FirstOrDefaultAsync(q => q.Id == id);


        public async Task Update(Platform entity)
            {
            var platform = await GetByIdAsync(entity.Id);
            platform.Type=entity.Type;
            }
        }
    }
