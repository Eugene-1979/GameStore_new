using Data.Interfaces;
using GameStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Interfaces
    {
     public interface IGameRepository :IRepository<Game>
        {

        Task <IEnumerable<Game>> GetGamesByGenreRepository (Guid key);

        Task<IEnumerable<Game>> GetGamesByPlatformRepository(Guid key);

        }
    }
