using WeatherTwentyOne.ViewModel;

namespace WeatherTwentyOne.Pages;

public partial class TaskDetail : ContentPage
{
	public TaskDetail(TaskHomeDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}