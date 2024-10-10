using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities
    {
    public class GamePlatform :BaseEntity
        {
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
    }
