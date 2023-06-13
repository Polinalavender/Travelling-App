namespace TravellingApp;

public partial class MapPage : ContentPage
{
	public MapPage()
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
}
