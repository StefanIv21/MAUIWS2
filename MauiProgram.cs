using Microsoft.Extensions.Logging;

namespace MauiWS2;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold"); fonts.AddFont("fa-solid-900.ttf", "FAS");
                fonts.AddFont("fa-regular-400.ttf", "FAR");
                fonts.AddFont("fab-regular-400.ttf", "FAB");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
