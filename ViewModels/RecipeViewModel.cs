using KitchenHelper.Models;
using KitchenHelper.Services.Interfaces;
using System.Collections.ObjectModel;

namespace KitchenHelper.ViewModels;

internal class RecipeViewModel
{
    private readonly IRecipeService _recipeService;
    private readonly IInventoryService _inventoryService;

    public ObservableCollection<Recipe> Recipes { get; } = new();
    public ObservableCollection<Ingredient> Ingredients { get; } = new();

    public string NewTitle { get; set; }

    public RecipeViewModel(IRecipeService recipeService, IInventoryService inventoryService)
    {
        _recipeService = recipeService;
        _inventoryService = inventoryService;

        InitData();
    }

    public async void InitData()
    {
        var ingredients =  await _inventoryService.GetAllIngredients();
        ingredients.ForEach(i => Ingredients.Add(i));

        LoadRecipes();
    }

    public async void LoadRecipes()
    {
        var items = await _recipeService.GetAllRecipes();
        Recipes.Clear();
        foreach (var item in items)
        {
            Recipes.Add(item);
        }
    }

    public async void AddRecipe()
    {
        var recipe = new Recipe(NewTitle);
        await _recipeService.AddRecipeAsync(recipe);
        LoadRecipes();
    }
}
