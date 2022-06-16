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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(registerPassword.Text != confirmPassword.Text)
            {
                DisplayAlert("Error", "The password do not match", "Try Again");
            }
            else
            {
                var db = new MongoCRUD();

                if (!db.CheckUserName(enteredName.Text))
                {
                    var person = new PersonModel { Username = enteredName.Text, Password = confirmPassword.Text };
                    db.InsertRecord(person);
                    DisplayAlert("Success", "Account was succesfully created!", "Proceed to login");
                    Navigation.PushAsync(new LogIn());
                }
                

            }

        }
    }
}