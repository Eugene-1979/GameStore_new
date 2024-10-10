using GameStore.Business;
using GameStore.Data.Data;

namespace GameStore.API
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<GameStoreContext>();
            builder.Services.AddControllers();

            builder.Services.AddAutoMapper(typeof(AutomapperProfile));
            Requiredservices.Reqired(builder);
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
            }
        }
    }
