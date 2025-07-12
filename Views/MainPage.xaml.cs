namespace KitchenHelper.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnGoToInventoryClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("InventoryPage");
    }
}
