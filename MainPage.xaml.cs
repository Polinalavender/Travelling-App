using Microsoft.Maui;
using Microsoft.Maui.Controls;
namespace travel_app;


public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Navigate to LoginPage when the MainPage is displayed
        await Navigation.PushAsync(new LogIn());
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }



    private void OnButtonClick(object sender, EventArgs e)
    {
        // Do something when the button is clicked
    }

}







