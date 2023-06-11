namespace travel_app;

public partial class Registaration : ContentPage
{
	public Registaration()
	{
		InitializeComponent();
	}

    private void OnSignUpButtonClicked(object sender, EventArgs e)
    {
        // Handle sign up button click logic here
    }

    private async void OnSignInTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LogIn());
    }
}
