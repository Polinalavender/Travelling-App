using DbWork.Data;
using DbWork.Model;

namespace DbWork;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		CounterBtn.Text = App.DataRepository._dbPath;

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		App.DataRepository.CreateTable();
		//App.DataRepository.Add(new Trip
		//{
		//	Location = "No"
		//});
		App.DataRepository.Add(new User
		{
			Username = "YE"
		});
		App.DataRepository.Add(new Pin { Name = "OPA" });

		CounterBtn.Text = App.DataRepository.GetTripById(1).Location + " " + App.DataRepository.GetUserById(1).Username + " " + App.DataRepository.GetMapPinById(1);

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

