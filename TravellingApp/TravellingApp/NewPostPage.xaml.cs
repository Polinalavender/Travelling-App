namespace TravellingApp;

public partial class NewPostPage : ContentPage
{
	public NewPostPage()
	{
		InitializeComponent();
	}
    private void OnAddPhotoButtonClicked(object sender, EventArgs e)
    {
        // Handle the button click event
        // Add your code to open the device's photo library or take a new photo

        // Example: Display an alert message when the button is clicked
        DisplayAlert("Button Clicked", "Add Photo button was clicked", "OK");
    }
    private void OnPublishButtonClicked(object sender, EventArgs e)
    {
        // Handle the button click event
        // Add your code to open the device's photo library or take a new photo

        // Example: Display an alert message when the button is clicked
        DisplayAlert("Button Clicked", "Add Photo button was clicked", "OK");
    }
    private void OnHomeImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void OnSavedImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LocationPage());
    }

    private void OnMapImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MapPage());
    }

    private void OnAccountImageTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccountPage());
    }
}
