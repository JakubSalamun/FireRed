using FireRed.Entities;

namespace FireRed.Interface
{
    public interface IAntagonista
    {
        void AddPokemonsToListOfAntagonistPokemons(Pokemons addPokemon);
        void GetPokemonsAntagonista();
        void przedstawSie();
    }
}