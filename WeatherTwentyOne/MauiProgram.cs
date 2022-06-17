﻿using WeatherTwentyOne.Pages;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne;

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

		builder.Services.AddSingleton<LoginService>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddTransient<LoginPage>();
       

        return builder.Build();
	}
}
