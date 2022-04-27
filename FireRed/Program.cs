using System;
using System.IO;
using System.Linq;
using FireRed.Entities;
using FireRed.Metody;
using FireRed.Postacie;
using FireRed.Data;
using System.Collections.Generic;

namespace FireRed
{
    class Program : Menu
    {    
        static void Main(string[] args)
        {
            //Baza danych
            SeedData();

            Menu menu = new Menu();
            if (menu.jsonDeserialize())
            {
                Console.WriteLine("Witaj przygodo");
                WybierzStartera();

            }
            else
            {
                 WczytaniMenuPoczatkowe();
            }
        }

      static void WczytaniMenuPoczatkowe()
        {
            Menu menu = new Menu();
            var plikPrzywitaniaTxt = File.ReadAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\Tekst\przywitanie.txt");
            menu.Print(plikPrzywitaniaTxt);
            menu.protagonistaInfo();
            menu.antagonistaInfo();
            var plikPrzedstawieniePostaci = File.ReadAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\Tekst\przedstawieniePostaci.txt");
        }

      static void WybierzStartera()
        {
            var dbContext = new FireRedDbContext();
            var pokemons = dbContext.Pokemons.ToList().Where(p=>p.Name== "Bulbasaur" || p.Name== "Charmander"|| p.Name== "Squirtle");
      

            //wyswitlenie listy pokemonów

            foreach (var item in pokemons)
            {
                Console.WriteLine($"Name:{item.Name},Type:{item.Type}");         
            }

            Console.Write("Wpisz kogo wybierasz: ");
            string wybieram = Console.ReadLine();

            Protagonista protagonista = new Protagonista();

           // protagonista.AddPokemonsToListOfProtagonistaPokemons(pokemonsBulba);
            

           

        }
        
        static void SeedData()
        {
            var dbContext = new FireRedDbContext();
            PokemonSeeder pokemonSeeder = new PokemonSeeder(dbContext);

            //uzupełnienie bazy danych
            pokemonSeeder.Seed();
        }
        
    }
}
