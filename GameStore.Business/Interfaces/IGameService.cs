
using GameStore.Business.Interfaces;
using GameStore.Business.Models;


namespace GameStore.Business.Interfaces
{
    public interface IGameService : ICrud<GameModel>
    {
        Task<GameModel> CetGameByKey(string key);


        Task <IEnumerable <GameModel>> GetGamesByGenre(Guid key);

        Task <IEnumerable<GameModel>> GetGamesByPlatform(Guid key);


        }
}
