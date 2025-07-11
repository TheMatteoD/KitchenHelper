using KitchenHelper.Models;
using KitchenHelper.Services.Interfaces;

namespace KitchenHelper.Services;

class InventoryService : IInventoryService
{
    public Task AddIngredientAsync(Ingredient ingredient)
    {
        throw new NotImplementedException();
    }

    public Task DeleteIngredientAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Ingredient>> GetAllIngredients()
    {
        throw new NotImplementedException();
    }
}
