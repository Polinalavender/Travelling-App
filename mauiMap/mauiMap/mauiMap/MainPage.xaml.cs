using Microsoft.Maui.Controls;
using Microsoft.Maui.Maps;
using System;
using System.Collections.ObjectModel;
using System.Globalization;

namespace mauiMap
{
    public partial class MainPage : ContentPage
    {
        private vModelMap viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new vModelMap();
            this.BindingContext = viewModel;
        }

        public void OnSubmit(object sender, EventArgs e)
        {
            // Retrieve the values from the Entry fields
            double lat = double.Parse(_lat.Text, CultureInfo.InvariantCulture);
            double longitude = double.Parse(_long.Text, CultureInfo.InvariantCulture);
            string address = addr.Text;
            string description = desc.Text;

            // Create a new PinViewModel instance and add it to the Pins collection
            viewModel.Pins.Add(new PinViewModel
            {
                Location = new Location(lat, longitude),
                Address = address,
                Description = description
            });
        }
    }

    public class vModelMap
    {
        public ObservableCollection<PinViewModel> Pins { get; set; }

        public vModelMap()
        {
            Pins = new ObservableCollection<PinViewModel>();

            // Add your previous pins here if needed
        }
    }

    public class PinViewModel
    {
        public Location Location { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
