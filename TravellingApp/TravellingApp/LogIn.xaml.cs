namespace TravellingApp;

using Microsoft.Maui.ApplicationModel.Communication;
using TravellingApp.Model;
public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();

    }

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        
        string username = usernameEntry.Text;

        if (username != "" && passwordEntry.Text != "")
        {
            string password = App.ComputeHash(passwordEntry.Text);
            if (App.DataRepository.GetUserByName(username) != null)
            {
                if (App.DataRepository.GetUserByName(username).Password == password)
                {
                    App.currentUser = new User
                    {
                        Username = username,
                        UserEmail = App.DataRepository.GetUserByName(username).UserEmail,
                    };
                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    DisplayAlert("Login Failed", "Invalid username or password", "OK");
                }
            }
            else
            {
                DisplayAlert("Login Failed", "Invalid username or password", "OK");
            }
        }
        
    }
    private async void OnSignUpLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registration());
    }

}

