using AutoMapper;
using GameStore.Business.Interfaces;
using Data.Interfaces;
using GameStore.Data.Interfaces;
using GameStore.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using GameStore.Business.Models;

namespace GameStore.Business.Services
{
    public class GenreService : IGenreService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public GenreService(IUnitOfWork unitOfWork, IMapper mapper)
            {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            }

        public Task AddAsync(GenreModel model)
            {
            /*  if(string.IsNullOrEmpty(model?.Name) || model.BirthDate > DateTime.Now || model.BirthDate < DateTime.Now.AddYears(-500)) throw new MarketException();*/
            var genre = mapper.Map<Genre>(model);
            unitOfWork.GenreRepository.AddAsync(genre);
            unitOfWork.SaveAsync();
            return Task.CompletedTask;
            }

        public async Task DeleteAsync(Guid modelId)
            {

            await unitOfWork.GenreRepository.DeleteByIdAsync(modelId);
            await unitOfWork.SaveAsync();

            }

        public Task<IEnumerable<GenreModel>> GetAllAsync()
            {
            throw new NotImplementedException();
            }

        public Task<GenreModel> GetByIdAsync(Guid id)
            {
            throw new NotImplementedException();
            }

    

        public Task UpdateAsync(GenreModel model)
            {
            throw new NotImplementedException();
            }
        }
}
