using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls;
using Bumptech.Glide.Load.Model;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;
using static Android.Icu.Text.Transliterator;
using AndroidX.Lifecycle;

namespace mauiMap;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new vModelMap();
    }

    public class vModelMap
    {
        public ObservableCollection<PinViewModel> Pins { get; set; }

        private int lat;
        private int _long;
        private String addr;
        private String desc;


        public vModelMap()
            {
                Pins = new ObservableCollection<PinViewModel>();

            /*Pins.Add(new PinViewModel
            {
                Location = new Location(39.9628066, -80.0194722), //latitude, longitude
                Address = "123 Main St",
                Description = "Pin 1"
            });*/ 

            /*Pins.Add(new PinViewModel
            {
                Location = new Location(36.9628067, -122.0194723),
                Address = "456 Elm St",
                Description = "Pin 2"
            });*/

        }

        public void OnSubmit(object sender, EventArgs e)
        {
            this.lat = lat;
            this._long = _long;
            this.addr = addr;
            this.desc = desc;


            Pins.Add(new PinViewModel
            {
                Location = new Location(this.lat, this._long), //latitude, longitude
                Address = this.addr,
                Description = this.desc
            });
        }

    }

    public class PinViewModel
    {
        public Location Location { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }


}


