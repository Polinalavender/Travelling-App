namespace TravellingApp;
using System.Security.Cryptography;

using System.Text;
using TravellingApp.Data;
using TravellingApp.Model;

public partial class App : Application
{
	public static DataRepo DataRepository { get; private set; }
    public static User currentUser { get; set; }
    public App(DataRepo dataRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();

		DataRepository = dataRepository;
		DataRepository.CreateTables();
    }
    public static string ComputeHash(string data)
    {
        byte[] hashBytes;
        using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes("IloveWeIRDHAsHKEYs")))
        {
            hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
        }
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
    }
}

