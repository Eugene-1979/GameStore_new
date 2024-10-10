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
    public class GenreRepository : IGenreRepository
        {
        private readonly GameStoreContext _context;

        public GenreRepository(GameStoreContext context)
            {
            _context = context;
            }
        public async Task AddAsync(Genre entity) => await _context.Genres.AddAsync(entity);


        public async void Delete(Genre entity)
            {
            var genre =await _context.Genres.FirstOrDefaultAsync(q => q.Id == entity.Id);
            _context.Genres.Remove(genre);
            }

        public async Task DeleteByIdAsync(Guid id)
            {
            var genre =await _context.Genres.FirstOrDefaultAsync(q => q.Id == id);
            _context.Genres.Remove(genre);
            }

        public async Task<IEnumerable<Genre>> GetAllAsync() => await _context.Genres.ToListAsync();


        public async Task<Genre> GetByIdAsync(Guid id) => await _context.Genres.FirstOrDefaultAsync(q => q.Id == id);


        public async Task Update(Genre entity)
            {
          var genre=await GetByIdAsync(entity.Id);
            genre.Name = entity.Name;
            genre.ParentGenreId = entity.ParentGenreId;


            genre.GameGenres = entity.GameGenres;
            }
        }
    }
