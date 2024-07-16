using WebApiPractice.Data;
using WebApiPractice.Interfaces;
using WebApiPractice.Modals;

namespace WebApiPractice.Repository
{
    public class PokemonRepository : IPokemonrepository
    {
        private readonly DataContext _dataContext;
        public PokemonRepository(DataContext context) {
            
            _dataContext = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _dataContext.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            return _dataContext.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review =  _dataContext.Reviews.Where(p => p.Pokemon.Id == pokeId);
            if(review.Count() <= 0)
            {
                return 0;
            }
            return ((decimal)review.Sum(r => r.Rating)/review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _dataContext.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            return _dataContext.Pokemon.Any(p => p.Id == pokeId);
        }
    }
}
