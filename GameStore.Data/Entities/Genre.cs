using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities
    {
    public class Genre : BaseEntity
        {

        public string Name { get; set; }
        public Guid ParentGenreId { get; set; }
        public virtual List<GameGenre> GameGenres { get; set; }
        }
    }
