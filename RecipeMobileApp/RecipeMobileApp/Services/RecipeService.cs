using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RecipeMobileApp.Common;
using RecipeMobileApp.Model;

namespace RecipeMobileApp.Services
{
	public class RecipeService : IRecipeService
    {

        private readonly IApiHelper _apiHelper;
        private readonly string BaseApiURL = "https://www.themealdb.com/api/json/v1/1/";

        public RecipeService(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<CategoryApiResponse> GetCategories()
        {
            try
            {
                CategoryApiResponse response = new CategoryApiResponse();
                HttpResponseMessage responseMessage = await _apiHelper.InvokeGetAPI(BaseApiURL + "categories.php");
                if (responseMessage.IsSuccessStatusCode)
                {
                    response = await ResponseContent<CategoryApiResponse>.ResponseContentAsync(responseMessage);
                }
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<MeailDetailApiResponse> GetMealDetail(string mealId)
        {
            try
            {
                string apiUrl = BaseApiURL+"lookup.php?i=" + mealId;
                MeailDetailApiResponse response = new MeailDetailApiResponse();
                HttpResponseMessage responseMessage = await _apiHelper.InvokeGetAPI(apiUrl);
                if (responseMessage.IsSuccessStatusCode)
                {
                    response = await ResponseContent<MeailDetailApiResponse>.ResponseContentAsync(responseMessage);
                }
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<MealApiResponse> GetMeals(string categoryName)
        {
            try
            {
                string apiUrl = BaseApiURL + "filter.php?c=" + categoryName;
                MealApiResponse response = new MealApiResponse();
                HttpResponseMessage responseMessage = await _apiHelper.InvokeGetAPI(apiUrl);
                if (responseMessage.IsSuccessStatusCode)
                {
                    response = await ResponseContent<MealApiResponse>.ResponseContentAsync(responseMessage);
                }
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

