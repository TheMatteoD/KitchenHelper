using KitchenHelper.Data;
using KitchenHelper.Models;
using KitchenHelper.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KitchenHelper.Services;

class RecipeService : IRecipeService
{
    private readonly KitchenDbContext _context;
    public RecipeService(KitchenDbContext context)
    {
        _context = context;
    }
    public async Task AddRecipeAsync(Recipe recipe)
    {
        await _context.Recipes.AddAsync(recipe);
        await _context.SaveChangesAsync();
    }

    public Task DeleteRecipeAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Recipe>> GetAllRecipes()
    {
        return await _context.Recipes.ToListAsync();
    }
}
