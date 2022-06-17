using WeatherTwentyOne.Pages;

namespace WeatherTwentyOne;

public partial class MainPage : ContentPage
{
	int count = 0;
	readonly LoginPage _loginPage;

    public MainPage(LoginPage loginPag)
	{
 
        InitializeComponent();
        _loginPage = loginPag;
    }

	private async void btnCaculator_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MainCaculator());
    }

	private async void btnLogin_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(_loginPage);
    }
}

