using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Data
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext()
        {
            
        }
        public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-UGIFB2Q;Initial Catalog=gamestore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
        public DbSet<GamePlatform> GamePlatforms { get; set; }
        public DbSet<Genre> Genres { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<GameGenre>().
           HasOne(q => q.Genre).
           WithMany(w => w.GameGenres).
           HasForeignKey(q => q.GenreId);


            modelBuilder.Entity<GameGenre>().
              HasOne(q => q.Game).
              WithMany(w => w.GameGenres).
              HasForeignKey(q => q.GameId);



            modelBuilder.Entity<GamePlatform>().
       HasOne(q => q.Platform).
       WithMany(w => w.GamePlatforms).
       HasForeignKey(q => q.PlatformId);

            modelBuilder.Entity<GamePlatform>().
              HasOne(q => q.Game).
              WithMany(w => w.GamePlatforms).
              HasForeignKey(q => q.GameId);


        }
    }
}
