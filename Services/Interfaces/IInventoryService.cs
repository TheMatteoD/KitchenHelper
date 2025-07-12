using KitchenHelper.Models;

namespace KitchenHelper.Services.Interfaces;

public interface IInventoryService
{
    Task<List<Ingredient>> GetAllIngredients();
    Task AddIngredientAsync(Ingredient ingredient);
    Task DeleteIngredientAsync(Guid id);
}
