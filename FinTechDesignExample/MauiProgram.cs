using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace FinTechDesignExample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Harabara.ttf");
				fonts.AddFont("Montserrat-Regular.ttf");
				fonts.AddFont("Montserrat-Bold.ttf");
				fonts.AddFont("theboldfont.ttf");
				fonts.AddFont("KeepCalm-Medium.ttf");
				fonts.AddFont("airstrike.ttf");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
