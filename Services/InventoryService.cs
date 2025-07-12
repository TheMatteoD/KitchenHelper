using KitchenHelper.Data;
using KitchenHelper.Models;
using KitchenHelper.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KitchenHelper.Services;

class InventoryService : IInventoryService
{
    private readonly KitchenDbContext _context;

    public InventoryService(KitchenDbContext context)
    {
        _context = context;
    }

    public Task AddIngredientAsync(Ingredient ingredient)
    {
        throw new NotImplementedException();
    }

    public Task DeleteIngredientAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Ingredient>> GetAllIngredients()
    {
        return await _context.Ingredients.ToListAsync();
    }
}
