using Pokemon_reviewApp.Models;

namespace Pokemon_reviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int Id);
        ICollection<Pokemon> GetPokemonByCategory (int CategoryId);
        bool CategoryExists(int Id); //for validation
    }
}
