using System;
using System.Collections.Generic;
using RecipeMobileApp.ViewModel;
using Xamarin.Forms;

namespace RecipeMobileApp.View
{	
	public partial class MealDetailPage : ContentPage
	{	
		public MealDetailPage ()
		{
			InitializeComponent ();
			BindingContext = new MealDetailViewModel();
		}
	}
}

