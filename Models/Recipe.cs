namespace KitchenHelper.Models;

class Recipe(string title)
{
    public Guid Id { get; set; }
    public string Title { get; set; } = title;
    public List<Ingredient> Ingredients { get; set; } = new ();
}
