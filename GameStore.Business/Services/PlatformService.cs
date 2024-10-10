using AutoMapper;
using GameStore.Business.Interfaces;

using Data.Interfaces;
using GameStore.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Data.Entities;

namespace GameStore.Business.Services
{
    public class PlatformService : IPlatformService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public PlatformService(IUnitOfWork unitOfWork, IMapper mapper)
            {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            }

        public Task AddAsync(PlatformModel model)
            {
            /*  if(string.IsNullOrEmpty(model?.Name) || model.BirthDate > DateTime.Now || model.BirthDate < DateTime.Now.AddYears(-500)) throw new MarketException();*/
            var platform = mapper.Map<Platform>(model);
            unitOfWork.PlatformRepository.AddAsync(platform);
            unitOfWork.SaveAsync();
            return Task.CompletedTask;
            }

        public async Task DeleteAsync(Guid modelId)
            {
            await unitOfWork.GenreRepository.DeleteByIdAsync(modelId);
            await unitOfWork.SaveAsync();
            }

        public Task<IEnumerable<PlatformModel>> GetAllAsync()
            {
            throw new NotImplementedException();
            }

        public Task<PlatformModel> GetByIdAsync(Guid id)
            {
            throw new NotImplementedException();
            }

       

        public Task UpdateAsync(PlatformModel model)
            {
            throw new NotImplementedException();
            }
        }
}
