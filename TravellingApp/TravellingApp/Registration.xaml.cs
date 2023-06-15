namespace TravellingApp;


public partial class Registration : ContentPage
{
	public Registration()
	{
		InitializeComponent();
	}

    private void OnSignUpButtonClicked(object sender, EventArgs e)
    {
        // Handle sign up button click logic here
        Navigation.PushAsync(new MainPage());

    }

    private async void OnSignInTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LogIn());
    }
}

