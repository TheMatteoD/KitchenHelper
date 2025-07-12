namespace KitchenHelper.Models;

class Recipe(string title, List<Ingredient> ingredients)
{
    public Guid Id { get; set; }
    public string Title { get; set; } = title;
    public List<Ingredient> Ingredients { get; set; } = ingredients;
}
