using Practica1LoginApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1LoginApp.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand Signupbtn { get; set; }

        public Person Person { get; set; } = new Person();

        public PropertiesItems PropertiesItems { get; set; } = new PropertiesItems();

        public SignUpPageViewModel()
        {
            Signupbtn = new Command(SignUp);
            PropertiesItems.SignUpText = "Sign Up";
            PropertiesItems.TitlePage = "Sign Up";
            PropertiesItems.TitleUsername = "Username";
            PropertiesItems.TitlePassword = "Password";
        }

        private async void SignUp()
        {
            if (string.IsNullOrEmpty(Person.Name) || string.IsNullOrEmpty(Person.Pass))
                await App.Current.MainPage.DisplayAlert("Error", "Empty fields", "Ok");
            else
                await App.Current.MainPage.DisplayAlert("Welcome", $"{Person.Name}", "Ok");
        }
    }
}
