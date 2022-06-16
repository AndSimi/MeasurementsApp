using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeasurementsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanBarcodePage : ContentPage
    {
        public ScanBarcodePage()
        {
            InitializeComponent();
        }

        private void Assign_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

            // Add a method to add the scanned plant to user db




        }
        //Enables the scanner
        private void Scan_Clicked(object sender, EventArgs e)
        {
            scanner.IsScanning = true;
            scanner.IsVisible = true;
            scanner.IsEnabled = true;


        }
        //Method used to scan the barcodes and set the label text to the results of the scan
        //After scanning the scanner is disabled again
        private void scanner_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                nameString.Text = result.Text;
                scanner.IsScanning = false;
                scanner.IsVisible = false;
                scanner.IsEnabled = false;
            });

        }
    }
}