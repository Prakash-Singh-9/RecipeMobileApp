using System;
using System.Collections.Generic;
using RecipeMobileApp.View;
using Xamarin.Forms;

namespace RecipeMobileApp
{	
	public partial class AppShellPage : Shell
	{	
		public AppShellPage ()
		{
			InitializeComponent ();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(MealsPage), typeof(MealsPage));
            Routing.RegisterRoute(nameof(MealDetailPage), typeof(MealDetailPage));  
        }
	}
}

