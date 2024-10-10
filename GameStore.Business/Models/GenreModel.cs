using AutoMapper;
using Data.Interfaces;
using GameStore.Business.Interfaces;
using GameStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Business.Models
    {
    public class GenreModel 
        {
        public string Name { get; set; }
        public Guid ParentGenreId { get; set; }
    /*    public virtual List<GameGenre> GameGenres { get; set; }*/
        }
    }
