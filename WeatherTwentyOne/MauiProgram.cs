using WeatherTwentyOne.Pages;
using WeatherTwentyOne.Services;
using WeatherTwentyOne.ViewModel;

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
        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<LoginService>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<LoginPage>();

		//Todo task
        builder.Services.AddTransient<TaskHome>();
        builder.Services.AddTransient<TaskDetail>();
        builder.Services.AddTransient<TaskHomeViewModel>();
		builder.Services.AddTransient<TaskHomeDetailViewModel>();



        return builder.Build();
	}
}
