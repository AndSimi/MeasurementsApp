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
        //When the User click register button the method will check if the entered passwords match, if not it will display an alert
        //and if they do match, the method will create a db object in order to access the database and check the username availability
        //if it's available will proceed to create a new user profile
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
                DisplayAlert("Error", "The username is already taken", "Try Again");

            }

        }
    }
}