using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Firebase.Storage;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Media;
using Microsoft.Maui.Storage;

namespace fbStorage;

public partial class MainPage : ContentPage
{
    //FirebaseStorage storage;
    public static FirebaseStorage Storage { get; set; }
    public MainPage()
    {
        InitializeComponent();
        //storage = new FirebaseStorage("mauitest-694e1.appspot.com");
        Storage = new FirebaseStorage("mauitest-694e1.appspot.com");
    }
    public async void OnUploadClicked(object sender, EventArgs e)
    {
        try 
        {
            FileResult result = await MediaPicker.PickPhotoAsync();
            if (result == null)
                return;
            string fileName = result.FileName;
            Stream stream = await result.OpenReadAsync();
            await Storage.Child("images/" + fileName).PutAsync(stream);
            await Navigation.PushAsync(new ImagePage(fileName));
        }
        catch (Exception ex)
        {
            errorLabel.Text = ex.Message; 
        }
    }
}

