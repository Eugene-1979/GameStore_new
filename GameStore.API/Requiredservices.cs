using Data.Data;
using Data.Interfaces;
using GameStore.Business.Interfaces;
using GameStore.Business.Services;
using GameStore.Data.Interfaces;
using GameStore.Data.Repositories;

namespace GameStore.API
    {
    public static class Requiredservices
        {
       public static void Reqired(WebApplicationBuilder webApplicationBuilder) {
            webApplicationBuilder.Services.AddScoped<IGameRepository, GameRepository>();
            webApplicationBuilder.Services.AddScoped<IGenreRepository, GenreRepository>();
            webApplicationBuilder.Services.AddScoped<IPlatformRepository, PlatformRepository>();
            webApplicationBuilder.Services.AddScoped<IGamePlatformRepository, GamePlatformRepository>();
            webApplicationBuilder.Services.AddScoped<IGameGenreRepository, GameGenreRepository>();


            webApplicationBuilder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            webApplicationBuilder.Services.AddScoped<IGameService,GameService>();
            webApplicationBuilder.Services.AddScoped<IGameService,GameService>();
            webApplicationBuilder.Services.AddScoped<IPlatformService,PlatformService>();
       
       
       }

        }
    }
