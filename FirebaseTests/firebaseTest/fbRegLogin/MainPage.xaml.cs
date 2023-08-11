namespace fbRegLogin;

/*
    Reference: https://www.youtube.com/watch?v=adk9RonuKw0&ab_channel=SingletonSean
    Package to install: FirebaseAuthentication.net
    Look into MauiProgram.cs first there is the configuration made to connect to Firebase and with the provider 
    set up as well
 */

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
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
}