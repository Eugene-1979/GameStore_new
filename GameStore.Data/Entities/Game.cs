using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities
    {
    public class Game :BaseEntity
        {
        public string Name { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public virtual List<GameGenre> GameGenres { get; set; }
        public virtual List<GamePlatform> GamePlatforms { get; set; }


        }
    }
