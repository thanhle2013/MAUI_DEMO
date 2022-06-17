using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.Pages;

public partial class LoginPage : ContentPage
{
	readonly LoginService _loginService;
    public LoginPage(LoginService loginService)
	{
        InitializeComponent();
        _loginService = loginService;
    }

	private async void btnLogin_Clicked(object sender, EventArgs e)
	{
		if(string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
		{
			 await DisplayAlert("Warning","Please input user and password.", "Ok");
			return;
		}

		var userInfo = await _loginService.Login(txtUserName.Text, txtPassword.Text);

		if(userInfo != null)
		{
			await DisplayAlert("Success" ,$"Hello {userInfo.FullName}, You are login success!!!", "Ok", "Close");
		}
		else
		{
            await DisplayAlert("Warning", "Login Failed.", "Ok");
            return;
        }

	}
}