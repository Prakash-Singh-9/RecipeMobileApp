using System;
using RecipeMobileApp.Model;
using RecipeMobileApp.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace RecipeMobileApp.ViewModel
{
    [QueryProperty(nameof(MealId), "MealIdParameter")]
    public class MealDetailViewModel : BaseViewModel
	{
        private string _mealId;
        public string MealId
        {
            get
            {
                return _mealId;
            }
            set
            {
                SetProperty(ref _mealId, value);
                GetMealDetail();
                OnPropertyChanged();
            }
        }


        private ObservableCollection<MealDetail> _mealDetailList;
        public ObservableCollection<MealDetail> MealDetailList
        {
            get { return _mealDetailList; }
            set { SetProperty(ref _mealDetailList, value); }
        }

        public MealDetailViewModel()
		{
          //TODO
		}

        public async void GetMealDetail()
        {
            var service = AppLocator.Instance.GetInstance<IRecipeService>();
            if (service != null)
            {
                MealDetailList = new ObservableCollection<MealDetail>();

                var apiResponse = await service.GetMealDetail(MealId);

                if (apiResponse != null)
                {
                    MealDetailList = new ObservableCollection<MealDetail>(apiResponse.meals);
                }
                else
                {
                    Console.WriteLine("An error occured from GetMealDetail Api.........");
                }
            }
        }
    }
}

