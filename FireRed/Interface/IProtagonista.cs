using FireRed.Entities;

namespace FireRed.Interface
{
    public interface IProtagonista
    {
        void AddMoney(int money);
        void AddPokemonsToListOfProtagonistaPokemons(Pokemons addPokemon);
        void GetPokemonsProtagonista();
        void przedstawSie();
    }
}