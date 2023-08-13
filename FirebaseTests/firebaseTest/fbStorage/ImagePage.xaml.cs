using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Storage;

namespace fbStorage;


public partial class ImagePage : ContentPage
{
    string fileName;
    public ImagePage(string fileName) {
        InitializeComponent();
        GetImageAsync(fileName);

    }

    private async Task GetImageAsync(string fileName) {
        FirebaseStorage storage = MainPage.Storage;
        var fileRef = storage.Child("images").Child(fileName);
        var url = await fileRef.GetDownloadUrlAsync();
        ImageView.Source = ImageSource.FromUri(new Uri(url));

    }
}
