using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonManager.Models
{
    public class PokemonModel
    {
        public int PokemonID { get; set; }
        public string PokemonName { get; set; }
        public string PokemonType { get; set; }
        public string Rarity { get; set; }
        public string IMGFilePath { get; set; }
    }
}