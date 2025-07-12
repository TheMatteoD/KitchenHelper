using System.Collections.ObjectModel;
using KitchenHelper.Models;
using KitchenHelper.Services.Interfaces;

namespace KitchenHelper.ViewModels;

public class InventoryViewModel
{
    private readonly IInventoryService _inventoryService;

    public ObservableCollection<Ingredient> Ingredients { get; } = new();

    public string NewName { get; set; }
    public string NewUnit { get; set; }
    public int NewQuantity { get; set; }

    public InventoryViewModel(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
        LoadIngredients();
    }

    public async void LoadIngredients()
    {
        var items = await _inventoryService.GetAllIngredients();
        Ingredients.Clear();
        foreach (var item in items)
            Ingredients.Add(item);
    }

    public async void AddIngredient()
    {
        var ingredient = new Ingredient(NewName, NewUnit);

        await _inventoryService.AddIngredientAsync(ingredient);
        LoadIngredients();
    }
}
