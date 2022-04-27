using FireRed.Entities;
using FireRed.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Postacie
{
    public class Antagonista : NPC, IAntagonista
    {
        private List<Pokemons> pokemons { get; set; }      
        public void przedstawSie()
        {
            Console.WriteLine("metoda z Antagonista");
            Console.WriteLine("Mam na imie " + nazwaPostaci);
        }

        public void GetPokemonsAntagonista()
        {
            foreach (var item in pokemons)
            {
                Console.WriteLine(item.Name + " : " + item.Lv);
            }
        }

        public void AddPokemonsToListOfAntagonistPokemons(Pokemons addPokemon)
        {
            pokemons.Add(addPokemon);
        }
    }
}
