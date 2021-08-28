using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1LoginApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1LoginApp.Droid.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }        
    }
}