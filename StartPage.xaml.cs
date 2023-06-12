namespace TravellingApp;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LogIn());
    }
}