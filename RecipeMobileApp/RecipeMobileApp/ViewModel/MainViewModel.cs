using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using RecipeMobileApp.Common;
using RecipeMobileApp.Model;
using RecipeMobileApp.Services;
using RecipeMobileApp.View;
using Xamarin.Forms;

namespace RecipeMobileApp.ViewModel
{
	public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Category> _cetegoryList;
        public ObservableCollection<Category> CetegoryList
        {
            get { return _cetegoryList; }
            set { SetProperty(ref _cetegoryList, value); }
        }

        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set { SetProperty(ref _selectedCategory, value); }
        }

        public ICommand SelectedItemCommand { get; set; }


        public MainViewModel()
		{
            InitCommand();
            GetCategoriesApiCall();
        }

		public async void GetCategoriesApiCall()
		{
			var service = AppLocator.Instance.GetInstance<IRecipeService>();
			if (service != null)
			{
                var apiResponse = await service.GetCategories();
				CetegoryList = new ObservableCollection<Category>();

				if (apiResponse != null)
				{
					CetegoryList = new ObservableCollection<Category>(apiResponse.categories);
				}
				else {

					Console.WriteLine("An error occured from GetCategories Api.....");
				}
			}
		}

        private void InitCommand()
        {
            SelectedItemCommand = new Command(ItemCommandExecute);
        }

        async private void ItemCommandExecute(object obj)
        {
            var category = obj as Category;
            await ShellRoutingService.Instance.NavigateTo($"{nameof(MealsPage)}?CategoryStringParameter={category.strCategory}");
        }
    }
}

