using FireRed.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Data
{

    /// <summary>
    /// dodać dane z programu do bazy danych 
    /// </summary>
   public class PokemonSeeder
    {
        private readonly FireRedDbContext _dbContext;

        public PokemonSeeder(FireRedDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Pokemons.Any())
                {
                    var pokemons = GetPokemons();
                    _dbContext.Pokemons.AddRange(pokemons);
                    _dbContext.SaveChanges();
                }
            }
        }

        private List<PokemonMoves> GetPokemonsMovesStarters()
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
        private List<PokemonMoves> GetPokemonsMovesStartersII()
        {
            var pokemonMoves = new List<PokemonMoves>()
            {
                 new PokemonMoves()
                    {
                        MoveName="Vine Whisp",
                        PokemonCanUse=true,
                        MovePower=45,
                        MoveAccurancy=100,
                        MoveCategory="Physical",
                        MoveLV=1,
                        MovePP=25,
                        MoveType="Grass"
                    },
                new PokemonMoves()
                    {
                        MoveName="Growth",
                        PokemonCanUse=true,
                        MovePower=0,
                        MoveAccurancy=100,
                        MoveCategory="Status",
                        MoveLV=1,
                        MovePP=20,
                        MoveType="Normal"
                    }
            };
            return pokemonMoves;
        }

        private List<Pokemons> GetPokemons()
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
                PokemonMoves= new List<PokemonMoves>(GetPokemonsMovesStarters()),          
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
                PokemonMoves=GetPokemonsMovesStarters(),
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
                PokemonMoves=GetPokemonsMovesStarters(),
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
    }
}
