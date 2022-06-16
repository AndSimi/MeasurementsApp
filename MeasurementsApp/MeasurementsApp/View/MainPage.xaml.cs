using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MeasurementsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ScanBarcode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScanBarcodePage());

        }


        private void CheckPlants_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Plants());

        }





    }
}
