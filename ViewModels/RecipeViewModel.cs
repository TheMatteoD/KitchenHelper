using KitchenHelper.Models;
using KitchenHelper.Services.Interfaces;
using System.Collections.ObjectModel;

namespace KitchenHelper.ViewModels;

internal class RecipeViewModel
{
    private readonly IRecipeService _recipeService;

    public ObservableCollection<Recipe> Recipes { get; } = new();

    public string NewTitle { get; set; }

    public RecipeViewModel(IRecipeService recipeService)
    {
        _recipeService = recipeService;
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
