using FireRed.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.SeedData
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
        private List<Pokemons> GetPokemons()
        {
            var pokemons = new List<Pokemons>()
            {
                new Pokemons()
                {
                Name="Bulbasaur",
                Lv=1,
                GenderType=Gender.Male,
                Type="Grass-Poison",
                PokemonMoves=new List<PokemonMoves>()
                {
                    new PokemonMoves()
                    {
                        MoveName="Tacle",
                        MovePower=20,
                        MoveAccurancy=100,
                        MoveCategory="Physical",
                        MoveLV=1,
                        MovePP=20,
                        MoveType="Normal"

                    }
                },
                PokemonStats=new PokemonStats()
                    {
                      ATK=10,
                      DEF=12,
                      HP=26,
                      SPATK=9,
                      SPDEF=14,
                      SPEED=7
                     }




                }
            };

            return pokemons;
        }
    }
}
