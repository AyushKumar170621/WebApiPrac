using WebApiPractice.Modals;

namespace WebApiPractice.Interfaces
{
    public interface IPokemonrepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);

        decimal GetPokemonRating(int pokeId);

        bool PokemonExists(int pokeId);

    }
}
