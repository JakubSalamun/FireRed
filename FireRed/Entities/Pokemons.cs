using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Entities
{
  public class Pokemons
    {
        public int Id { get; set; }
        public int Lv { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Gender GenderType { get; set; }

        public int PokemonStatsId { get; set; }
        public virtual PokemonStats PokemonStats { get; set; }
        public int PokemonMovesId { get; set; }
        public virtual List<PokemonMoves> PokemonMoves { get; set; }

    }
}
