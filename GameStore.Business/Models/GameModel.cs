using AutoMapper;
using Data.Interfaces;
using GameStore.Business.Interfaces;
using GameStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Business.Models
    {
    public class GameModel 
        {
        public string Name { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
/*        public virtual List<GameGenre> GameGenres { get; set; }
        public virtual List<GamePlatform> GamePlatforms { get; set; }*/

        }
    }
