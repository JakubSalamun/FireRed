using System;
using System.IO;
using System.Linq;
using FireRed.Entities;
using FireRed.Metody;
using FireRed.Postacie;
using FireRed.Data;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace FireRed
{
    class Program 
    {    
        static void Main(string[] args)
        {
            //JSON z danymi pokemon/stats/moves
            Pokedex();
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

            var pokemons = dbContext.Pokemons
                .Include(m => m.PokemonMoves)
                .Include(s => s.PokemonStats)
                .Where(p => p.Name == "Bulbasaur" || p.Name=="Squirtle"|| p.Name=="Charmander")
                .ToList();
               
      
            //wyswitlenie listy pokemonów
            foreach (var item in pokemons)
            {
                Console.WriteLine($"Name:{item.Name},Type:{item.Type}");
              
                    Console.WriteLine($"HP:{item.PokemonStats.HP}");
                    Console.WriteLine($"ATK:{item.PokemonStats.ATK}");
                    Console.WriteLine($"ATK:{item.PokemonStats.DEF}");
                    Console.WriteLine($"SPATK:{item.PokemonStats.SPATK}");
                    Console.WriteLine($"SPDEF:{item.PokemonStats.SPDEF}");                
                    Console.WriteLine($"SPEED:{item.PokemonStats.SPEED}");
                var moveList = item.PokemonMoves;
                foreach (var move in moveList)
                {
                    Console.WriteLine(move.MoveName);
                }
            
            }
        }
        
      static void SeedData()
        {
           var dbContext = new FireRedDbContext();
           PokemonSeeder pokemonSeeder = new PokemonSeeder(dbContext);
  
           //uzupełnienie bazy danych
           pokemonSeeder.Seed();
        }  
      static void Pokedex()
        {
            List<PokemonMoves> GetPokemonsMoves()
            {
                var pokemonMoves = new List<PokemonMoves>()
            {
                 new PokemonMoves()
                    {
                        MoveName="Tacle",
                        PokemonCanUse=true,
                        MovePower=20,
                        MoveAccurancy=100,
                        MoveCategory="Physical",
                        MoveLV=1,
                        MovePP=35,
                        MoveType="Normal",


                    },
                new PokemonMoves()
                    {
                        MoveName="Growl",
                        PokemonCanUse=true,
                        MovePower=0,
                        MoveAccurancy=100,
                        MoveCategory="Status",
                        MoveLV=1,
                        MovePP=40,
                        MoveType="Normal",

                    },
                new PokemonMoves()
                    {
                        MoveName="Ember",
                        PokemonCanUse=false,
                        MovePower=40,
                        MoveAccurancy=100,
                        MoveCategory="Special",
                        MoveLV=1,
                        MovePP=25,
                        MoveType="Fire",

                    },
                new PokemonMoves()
                    {
                        MoveName="Water Gun",
                        PokemonCanUse=false,
                        MovePower=40,
                        MoveAccurancy=100,
                        MoveCategory="Special",
                        MoveLV=3,
                        MovePP=25,
                        MoveType="Water"
                    },
                new PokemonMoves()
                    {
                        MoveName="Vine Whip",
                        PokemonCanUse=false,
                        MovePower=45,
                        MoveAccurancy=100,
                        MoveCategory="Physical",
                        MoveLV=3,
                        MovePP=25,
                        MoveType="Grass",
                    },


            };
                return pokemonMoves;
            }
            List<Pokemons> GetPokemons()
            {

                var pokemons = new List<Pokemons>()
            {
                //Bulbasaur
                new Pokemons()
                {
                Name="Bulbasaur",
                Lv=1,
                GenderType=Gender.Male,
                Type="Grass-Poison",
                PokemonMoves= GetPokemonsMoves(),
                PokemonStats=new PokemonStats()
                    {
                      HP=29,
                      ATK=14,
                      DEF=16,
                      SPATK=17,
                      SPDEF=13,
                      SPEED=8
                     }
                },

                //Charmander
                new Pokemons()
                {
                Name="Charmander",
                Lv=1,
                GenderType=Gender.Male,
                Type="Fire",
                PokemonMoves=GetPokemonsMoves(),
                PokemonStats=new PokemonStats()
                    {
                      HP=26,
                      ATK=19,
                      DEF=9,
                      SPATK=16,
                      SPDEF=11,
                      SPEED=19
                     }
                },

                //Squirtle
                new Pokemons()
                {
                Name="Squirtle",
                Lv=1,
                GenderType=Gender.Male,
                Type="Water",
                PokemonMoves=GetPokemonsMoves(),
                PokemonStats=new PokemonStats()
                    {
                      HP=24,
                      ATK=15,
                      DEF=15,
                      SPATK=19,
                      SPDEF=15,
                      SPEED=17
                     }
                }
            };

                return pokemons;
            }

            var pokemon = JsonConvert.SerializeObject(GetPokemons());
            File.WriteAllText(@"C:\Users\AskIT\source\repos\FireRed\FireRed\JSON\Pokedex.json", pokemon);



        }
    }
}
