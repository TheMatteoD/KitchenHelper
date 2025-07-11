namespace KitchenHelper.Models;

public class Ingredient(string name, string unit)
{
    public Guid Id { get; set; }
    public string Name { get; set; } = name;
    public int Quantity { get; set; }
    public string Unit { get; set; } = unit; // TODO: Create a units enum
}
