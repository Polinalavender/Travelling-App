namespace TravellingApp;

public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (AuthenticateUser(username, password))
        {
            // Navigate to the next page in your app
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            DisplayAlert("Login Failed", "Invalid username or password", "OK");
        }
    }

    private bool AuthenticateUser(string username, string password)
    {
        // Authenticate the user's credentials here
        if (username == "admin" && password == "password")
        {
            // If the user's credentials are valid, return true
            return true;
        }
        else
        {
            // If the user's credentials are invalid, return false
            return false;
        }
    }

    private async void OnSignUpLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registration());
    }

}

