using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeasurementsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MongoCRUD db = new MongoCRUD();
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new LogIn());
           
           
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
