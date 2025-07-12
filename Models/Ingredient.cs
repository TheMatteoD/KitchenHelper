namespace KitchenHelper.Models;

public class Ingredient(string name, int quantity, string unit)
{
    public Guid Id { get; set; }
    public string Name { get; set; } = name;
    public int Quantity { get; set; } = quantity;
    public string Unit { get; set; } = unit; // TODO: Create a units enum
}
