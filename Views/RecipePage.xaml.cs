using KitchenHelper.Services.Interfaces;
using KitchenHelper.ViewModels;

namespace KitchenHelper.Views;

public partial class RecipePage : ContentPage
{
    private RecipeViewModel ViewModel => (RecipeViewModel)BindingContext;

    public RecipePage(IRecipeService recipeService, IInventoryService inventoryService)
    {
        InitializeComponent();
        BindingContext = new RecipeViewModel(recipeService, inventoryService);
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        ViewModel.AddRecipe();
    }
}
