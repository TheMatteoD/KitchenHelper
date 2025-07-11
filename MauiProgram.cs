using KitchenHelper.Data;
using KitchenHelper.Services;
using KitchenHelper.Services.Interfaces;
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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
