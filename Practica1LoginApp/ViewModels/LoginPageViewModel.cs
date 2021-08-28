using Practica1LoginApp.Models;
using Practica1LoginApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1LoginApp.ViewModels
{
    public class LoginPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand Loginbtn { get; set; }

        public ICommand Signupbtn { get; set; }

        public Person Person { get; set; } = new Person();

        public PropertiesItems PropertiesItems { get; set; } = new PropertiesItems();

        public LoginPageViewModel()
        {
            Loginbtn = new Command(login);
            PropertiesItems.LogInText = "Log in";
            PropertiesItems.TitlePage = "Log in";
            PropertiesItems.SignUpText = "Sign Up";
            PropertiesItems.TitleUsername = "Username";
            PropertiesItems.TitlePassword = "Password";
            Signupbtn = new Command(SignUp);
        }

        //Event to button LogIn//
        private async void login()
        {
            if (string.IsNullOrEmpty(Person.Name) || string.IsNullOrEmpty(Person.Pass))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Empty fields", "Ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
        }

        //Event to button SignUp//
        private async void SignUp()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}
