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
    public class GameRepository : IGameRepository
        {
        private readonly GameStoreContext _context;

        public GameRepository(GameStoreContext context)
            {
            _context = context;
            }

        public async Task AddAsync(Game entity) 
        {
        await _context.Games.AddAsync(entity); 
        }


        public async void Delete(Game entity)
            {
            var game =await _context.Games.FirstOrDefaultAsync(q => q.Id == entity.Id);
            _context.Games.Remove(game);

            }

        public async Task DeleteByIdAsync(Guid id)
            {
            var game =await _context.Games.FirstOrDefaultAsync(q => q.Id == id);
            _context.Games.Remove(game);
            }

        public async Task<IEnumerable<Game>> GetAllAsync() =>await _context.Games.ToListAsync();


        public async Task<Game> GetByIdAsync(Guid id)=>await _context.Games.FirstOrDefaultAsync(q => q.Id == id);

        public async Task<IEnumerable<Game>> GetGamesByGenreRepository(Guid key)
            {

            var game_gemes = await _context.GameGenres.Where(q => q.GenreId == key).ToListAsync();
            List<Game> games = new List<Game>();
            foreach(var item in game_gemes)
                {
                var game = await GetByIdAsync(item.GameId);
                games.Add(game);
                }

            return games;

            }

        public async Task<IEnumerable<Game>> GetGamesByPlatformRepository(Guid key)
            {
        var game_platforms=  await  _context.GamePlatforms.Where(q => q.PlatformId == key).ToListAsync();
            List<Game> games = new List<Game>();
            foreach (var item in game_platforms)
            {
                var game = await GetByIdAsync(item.GameId);
                games.Add(game);
            }

            return games;
        }

        public async Task Update(Game entity)
            {
           var game=await GetByIdAsync(entity.Id);
            game.Description = entity.Description;
            game.Key = entity.Key;
            game.Name = entity.Name;

            }
        }
    }
