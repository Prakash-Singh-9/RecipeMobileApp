using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using RecipeMobileApp.Common;
using RecipeMobileApp.Model;
using RecipeMobileApp.Services;
using RecipeMobileApp.View;
using Xamarin.Forms;

namespace RecipeMobileApp.ViewModel
{
    [QueryProperty(nameof(StrCategory), "CategoryStringParameter")]
    public class MealsViewModel :BaseViewModel
	{
        
        private string _strCategory;
        public string StrCategory
        {
            get
            {
                return _strCategory;
            }
            set
            {
                SetProperty(ref _strCategory, value);
                GetMealsApiCall();
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Meal> _mealList;
        public ObservableCollection<Meal> MealList
        {
            get { return _mealList; }
            set { SetProperty(ref _mealList, value); }
        }

        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set { SetProperty(ref _selectedCategory, value); }
        }

        public ICommand SelectedItemCommand { get; set; }

        public MealsViewModel()
		{
            InitCommand();
        }

        public async void GetMealsApiCall()
        {
            var service = AppLocator.Instance.GetInstance<IRecipeService>();
            if (service != null)
            {
                MealList = new ObservableCollection<Meal>();
                var apiResponse = await service.GetMeals(StrCategory);

                if (apiResponse != null)
                {
                    MealList = new ObservableCollection<Meal>(apiResponse.meals);
                }
                else
                {
                    Console.WriteLine("An error occured from GetMeals Api....");
                }
            }
        }

        private void InitCommand()
        {
            SelectedItemCommand = new Command(ItemCommandExecute);
        }

        async private void ItemCommandExecute(object obj)
        {
            var meal = obj as Meal;
            await ShellRoutingService.Instance.NavigateTo($"{nameof(MealDetailPage)}?MealIdParameter={meal.idMeal}");
        }
    }
}

