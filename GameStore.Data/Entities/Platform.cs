using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities
    {
    public class Platform :BaseEntity
        {
        public string Type { get; set; }
        public virtual List<GamePlatform> GamePlatforms { get; set; }
        }
    }
