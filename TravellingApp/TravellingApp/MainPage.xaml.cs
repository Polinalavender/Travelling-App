namespace TravellingApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        userMain.Text = "Welcome back, " + App.currentUser.Username;

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
        Navigation.PushAsync(new SearchPage());
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    private void forYouBC(object sender, EventArgs e)
    {
        mViewedL.IsVisible = false;
        allL.IsVisible = false;
        forYouL.IsVisible = true;
    }

    private void mViewedBC(object sender, EventArgs e)
    {
        forYouL.IsVisible = false;
        allL.IsVisible = false;
        mViewedL.IsVisible = true;
    }

    private void allBC(object sender, EventArgs e)
    {
        mViewedL.IsVisible = false;
        forYouL.IsVisible = false;
        allL.IsVisible = true;
    }

    private void OnSearchButtonPressed(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SearchPage());
    }

    private void OnFrameTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SearchPage());
    }
    
}

