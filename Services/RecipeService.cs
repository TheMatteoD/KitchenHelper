using KitchenHelper.Models;
using KitchenHelper.Services.Interfaces;

namespace KitchenHelper.Services;

class RecipeService : IRecipeService
{
    public Task AddRecipeAsync(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRecipeAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Recipe>> GetAllRecipes()
    {
        throw new NotImplementedException();
    }
}
