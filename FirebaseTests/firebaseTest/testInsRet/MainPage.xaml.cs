//Make sure to have the Query added as well from Firebase (in using Firebase.Database.Query)

using System.Collections.ObjectModel;
using Firebase.Database;
using Firebase.Database.Query;

namespace testInsRet;

//Nugget Package needed: FirebaseDatabase.net
public partial class MainPage : ContentPage
{
    //int count = 0;

    //Create the firebase client instance (the url is the one displayed on the real time database page)
    FirebaseClient firebaseClient =
        new FirebaseClient("https://mauitest-694e1-default-rtdb.europe-west1.firebasedatabase.app");

    /*
        Retrieval of objects from the db
        
        On short an ObservableCollection is used for the UI. When an element it's added or removed the UI is notified
        as well to add or remove an item.
     */
    public ObservableCollection<Item> ObsvervableItems { get; set; } = new ObservableCollection<Item>();
    
    public MainPage()
    {
        InitializeComponent();
        //! Don't forget this
        BindingContext = this;
        
        
        //Creating a collection which will retrieve the contents of NodeName node
        var collection = firebaseClient
            .Child("NodeName")
            .AsObservable<Item>()
            .Subscribe((item) =>
            {
                if (item.Object != null)
                {
                    ObsvervableItems.Add(item.Object);
                }
            });
    }

    //Reference: https://cedricgabrang.medium.com/realtime-database-with-firebase-in-net-maui-60323460ef7e

    //Send the object into the database
    private void sendObj(object sender, EventArgs e)
    {
        //Where NodeName is placed that means that's the name of the node that's going to have the data stored in the db
        /*
            PostAsync sends a POST type request and pushes the item into the FirebaseDatabase
            The Item class contains the method testString
         */
        firebaseClient.Child("NodeName").PostAsync(new Item
        {
            testString = stringEntry.Text,
        });
    }
}