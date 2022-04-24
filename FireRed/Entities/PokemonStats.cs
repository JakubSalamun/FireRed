using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Entities
{
   public class PokemonStats
    {
        public int Id { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int SPATK { get; set; }
        public int SPDEF { get; set; }
        public int SPEED { get; set; }

        public int PokemonId { get; set; }
        public virtual Pokemons Pokemons { get; set; }
    }
}
