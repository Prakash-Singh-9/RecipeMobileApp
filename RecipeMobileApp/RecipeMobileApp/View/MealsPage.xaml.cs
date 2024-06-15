using System;
using System.Collections.Generic;
using RecipeMobileApp.ViewModel;
using Xamarin.Forms;

namespace RecipeMobileApp.View
{
   
    public partial class MealsPage : ContentPage
	{
		MealsViewModel viewModel;
		public MealsPage ()
		{
			InitializeComponent ();
			BindingContext = viewModel = new MealsViewModel();

        }
	}
}

