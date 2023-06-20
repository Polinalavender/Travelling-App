using Microsoft.Extensions.Logging;
using TravellingApp.Data;
namespace TravellingApp;

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

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "appDb.db");

        builder.Services.AddSingleton<DataRepo>(s => ActivatorUtilities.CreateInstance<DataRepo>(s, dbPath));

        return builder.Build();
	}
}

