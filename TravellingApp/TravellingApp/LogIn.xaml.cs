namespace TravellingApp;
using TravellingApp.Model;
public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        App.DataRepository.Add(new User { Username = "admin", Password = "pw" });
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        if (username != "" && password != "")
        {
            if(App.DataRepository.GetUserByName(username).Password == password)
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Login Failed", "Invalid username or password", "OK");
            }
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

