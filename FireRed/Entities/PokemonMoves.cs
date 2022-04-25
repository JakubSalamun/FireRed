using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Entities
{
  public  class PokemonMoves
    {
        public int Id { get; set; }
        public bool PokemonCanUse { get; set; }
        public int MoveLV { get; set; }
        public string MoveName { get; set; }
        public string MoveType { get; set; }//można zmienić w enum od typu ruchu
        public string MoveCategory { get; set; } //można zmienić w enum fizyczny/specjalny/status
        public int MovePower { get; set; }
        public int MoveAccurancy { get; set; }
        public int MovePP { get; set; }

        public int PokemomId { get; set; }
        public virtual Pokemons Pokemons { get; set; }


    }
}
