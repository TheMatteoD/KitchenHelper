using KitchenHelper.Services.Interfaces;
using KitchenHelper.ViewModels;

namespace KitchenHelper.Views;

public partial class InventoryPage : ContentPage
{
    private InventoryViewModel ViewModel => (InventoryViewModel)BindingContext;

    public InventoryPage(IInventoryService service)
    {
        InitializeComponent();
        BindingContext = new InventoryViewModel(service);
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        ViewModel.AddIngredient();
    }
}
