﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Business.Interfaces
{
    public interface ICrud<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync();

        Task<TModel> GetByIdAsync(Guid id);

        Task AddAsync(TModel model);

        Task UpdateAsync(TModel model);

        Task DeleteAsync(Guid modelId);
    }
}
