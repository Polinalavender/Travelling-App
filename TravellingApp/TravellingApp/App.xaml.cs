namespace TravellingApp;
using TravellingApp.Data;

public partial class App : Application
{
	public static DataRepo DataRepository { get; private set; }	
    public App(DataRepo dataRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();

		DataRepository = dataRepository;
		DataRepository.CreateTables();
	}
}

