namespace TravellingApp;


public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

    private void OnHomeImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void OnSavedImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SavedPage());
    }

    private void OnMapImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MapPage());
    }

    private void OnAccountImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccountPage());
    }

    private void OnFollowButtonClicked(object sender, EventArgs e)
    {
        /*if (FollowButton.Text == "Follow")
        {
            
            FollowButton.Text = "Followed";
            FollowButton.BackgroundColor = Color.Red; 
        }
        else
        {
            
            FollowButton.Text = "Follow";
            FollowButton.BackgroundColor = Color.Blue; 
        }*/
    }
    private void NewPostTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPostPage());
    }
    
}
