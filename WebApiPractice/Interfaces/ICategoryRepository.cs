using WebApiPractice.Modals;

namespace WebApiPractice.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExisits(int id);
        bool CategoryExists(int pokeId);
    }
}
