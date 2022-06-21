using WeatherTwentyOne.ViewModel;

namespace WeatherTwentyOne.Pages;

public partial class TaskHome : ContentPage
{
	public TaskHome(TaskHomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}