using Practica1LoginApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Practica1LoginApp.ViewModels
{
    public class HomePageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MenuOptions MenuOptions { get; set; } = new MenuOptions();

        public PropertiesItems PropertiesItems { get; set; } = new PropertiesItems();

        public HomePageViewModel()
        {
            PropertiesItems.TitlePage = "Menu";
            MenuOptions.CoffeeTitle = "Coffee";
            MenuOptions.DessertTitle = "Desserts";
            MenuOptions.FoodTitle = "Fast food";
            MenuOptions.DrinksImage = "Drinks";
            MenuOptions.BarTitle = "Bar and Hotels";
            MenuOptions.HealthyTitle = "Healthy Food";
            MenuOptions.BarImage = "https://img.icons8.com/ios-filled/60/000000/bar.png";
            MenuOptions.FoodImage = "https://img.icons8.com/ios-glyphs/60/000000/kawaii-pizza.png";
            MenuOptions.HealthyImage = "https://img.icons8.com/ios-glyphs/60/000000/bitten-apple.png";
            MenuOptions.DrinksImage = "https://img.icons8.com/ios-glyphs/60/000000/coconut-cocktail.png";
            MenuOptions.DessertImage = "https://img.icons8.com/ios-glyphs/60/000000/ice-pop-pink--v1.png";
            MenuOptions.CoffeeImage = "https://img.icons8.com/ios-glyphs/60/000000/coffee-break.png";
        }

    }
}