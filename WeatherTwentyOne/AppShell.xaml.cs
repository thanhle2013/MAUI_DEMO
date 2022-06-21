using WeatherTwentyOne.Pages;

namespace WeatherTwentyOne;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//Regiter router
		Routing.RegisterRoute(nameof(TaskDetail), typeof(TaskDetail));
	}
}
