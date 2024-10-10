
using GameStore.Business.Interfaces;
using Data.Interfaces;
using GameStore.Business.Models;
using GameStore.Data.Entities;
using AutoMapper;




namespace GameStore.Business.Services
{
    public class GameService : IGameService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public GameService(IUnitOfWork unitOfWork, IMapper mapper)
            {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            }


        public Task AddAsync(GameModel model)
            {
            /*  if(string.IsNullOrEmpty(model?.Name) || model.BirthDate > DateTime.Now || model.BirthDate < DateTime.Now.AddYears(-500)) throw new MarketException();*/
            var game = mapper.Map<Game>(model);
            unitOfWork.GameRepository.AddAsync(game);
            unitOfWork.SaveAsync();
            return Task.CompletedTask;
            }

        public Task<GameModel> CetGameByKey(string key)
            {
            throw new NotImplementedException();
            }

        public async Task DeleteAsync(Guid modelId)
            {
            await unitOfWork.GameRepository.DeleteByIdAsync(modelId);
            await unitOfWork.SaveAsync();
            }

        public async Task<IEnumerable<GameModel>> GetAllAsync()
            {
           var games= await unitOfWork.GameRepository.GetAllAsync();
            List<GameModel> gameModels = new List<GameModel>();


            foreach (var item in games)
            {
                GameModel gameModel = new GameModel();
                mapper.Map(item, gameModel);
                gameModels.Add(gameModel);
                }

            return gameModels;
            }

        public async Task<GameModel> GetByIdAsync(Guid id)
            {
           var game=await unitOfWork.GameRepository.GetByIdAsync(id);

            GameModel gameModel = new GameModel();
            mapper.Map(game,gameModel);

            return gameModel;
            }

        public async Task UpdateAsync(GameModel model)
            {

          var game=  mapper.Map<Game>(model);
        await  unitOfWork.GameRepository.Update(game);
            await unitOfWork.SaveAsync();
            }




        public async Task<IEnumerable<GameModel>> GetGamesByPlatform(Guid key)
            {

            var games = await unitOfWork.GameRepository.GetGamesByPlatformRepository(key);


            List<GameModel> gameModels = new List<GameModel>();


            foreach(var item in games)
                {
                GameModel gameModel = new GameModel();
                mapper.Map(item, gameModel);
                gameModels.Add(gameModel);
                }

            return gameModels;


            }

        public async Task<IEnumerable<GameModel>> GetGamesByGenre(Guid key)
            {
            var games = await unitOfWork.GameRepository.GetGamesByGenreRepository(key);


            List<GameModel> gameModels = new List<GameModel>();


            foreach(var item in games)
                {
                GameModel gameModel = new GameModel();
                mapper.Map(item, gameModel);
                gameModels.Add(gameModel);
                }

            return gameModels;
            }
        }
}
