using DbWork.Data;
using DbWork.Model;

namespace DbWork;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		App.DataRepository.CreateTable();
		App.DataRepository.Add(new Trip
		{
			Location = "No"
		});


		CounterBtn.Text = App.DataRepository.GetTripById(1).Location;

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

