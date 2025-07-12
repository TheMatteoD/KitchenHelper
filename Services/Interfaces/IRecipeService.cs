using KitchenHelper.Models;

namespace KitchenHelper.Services.Interfaces;

interface IRecipeService
{
    Task<List<Recipe>> GetAllRecipes();
    Task AddRecipeAsync(Recipe recipe);
    Task DeleteRecipeAsync(Guid id);
}
