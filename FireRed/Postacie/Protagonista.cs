using FireRed.Entities;
using FireRed.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Postacie
{
    public class Protagonista : NPC, IProtagonista
    {
        private List<Pokemons> pokemons { get; set; }
        private int Portfel { get; set; }
        public void przedstawSie()
        {
            Console.WriteLine("metoda z Protagonista");
            Console.WriteLine("Mam na imie " + nazwaPostaci + " ,jestem " + (gender == Gender.Male ? "Chłopcem " : "Dziewczynką"));
        }

        public void AddMoney(int money)
        {
            if (money > 0)
            {
                Portfel += money;
            }
            else
            {
                Console.WriteLine("Nie dodano środków");
            }

        }
        public void GetPokemonsProtagonista()
        {
            foreach (var item in pokemons)
            {
                Console.WriteLine(item.Name + " : " + item.Lv);
            }
        }

        public void AddPokemonsToListOfProtagonistaPokemons(Pokemons addPokemon)
        {
            pokemons.Add(addPokemon);
        }

    }
}
