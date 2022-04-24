using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRed.Entities
{
    public  class FireRedDbContext : DbContext
    {
        private string _connectionString = "Server=ASK\\SQLEXPRESS;Database=FireRedDB;Trusted_Connection=True;";
        public DbSet<Pokemons> Pokemons { get; set; }
        public DbSet<PokemonStats> PokemonStats { get; set; }
        public DbSet<PokemonMoves> PokemonMoves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
