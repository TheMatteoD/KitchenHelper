using KitchenHelper.Models;
using Microsoft.EntityFrameworkCore;

namespace KitchenHelper.Data;

class KitchenDbContext : DbContext
{
    public KitchenDbContext(DbContextOptions<KitchenDbContext> options) : base(options) { }

    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
}
