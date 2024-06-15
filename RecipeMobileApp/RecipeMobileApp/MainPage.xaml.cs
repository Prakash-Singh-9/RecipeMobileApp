using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeMobileApp.View;
using RecipeMobileApp.ViewModel;
using Xamarin.Forms;

namespace RecipeMobileApp
{
    public partial class MainPage : ContentPage
    {
        MainViewModel mainViewModel;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = mainViewModel = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}

