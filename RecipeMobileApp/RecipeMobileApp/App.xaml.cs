using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecipeMobileApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();
            AppLocator.Instance.Register();
            MainPage = new AppShellPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

