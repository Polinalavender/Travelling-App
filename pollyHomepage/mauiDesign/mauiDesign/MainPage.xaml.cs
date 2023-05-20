using System.Windows.Input;

namespace mauiDesign;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
        InitializeComponent();
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
}


