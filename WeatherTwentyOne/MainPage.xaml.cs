using WeatherTwentyOne.Pages;

namespace WeatherTwentyOne;

public partial class MainPage : ContentPage
{
	int count = 0;
	readonly LoginPage _loginPage;
    readonly TaskHome _taskHomePage;

    public MainPage(LoginPage loginPag, TaskHome taskHomePage)
    {

        InitializeComponent();
        _loginPage = loginPag;
        _taskHomePage = taskHomePage;
    }

    private async void btnCaculator_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MainCaculator());
    }

	private async void btnLogin_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(_loginPage);
    }

    private async void btnTask_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_taskHomePage);
    }
}

