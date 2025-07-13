using KitchenHelper.Data;
using KitchenHelper.Services;
using KitchenHelper.Services.Interfaces;
using KitchenHelper.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KitchenHelper;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Register SQLite DB
		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "kitchen.db");
		builder.Services.AddDbContext<KitchenDbContext>(options =>
			options.UseSqlite($"Filename={dbPath}"));

		// Register services
		builder.Services.AddScoped<IInventoryService, InventoryService>();
        builder.Services.AddScoped<IRecipeService, RecipeService>();

        builder.Services.AddTransient<InventoryPage>();
		builder.Services.AddTransient<RecipePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		var app = builder.Build();
		using var scope = app.Services.CreateScope();

		// Ensure DB is created on startup
		var db = scope.ServiceProvider.GetRequiredService<KitchenDbContext>();
		db.Database.EnsureCreated();

        return app;
	}
}
