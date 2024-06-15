using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RecipeMobileApp.Model;

namespace RecipeMobileApp.Services
{
	public interface IRecipeService
	{
        Task<CategoryApiResponse> GetCategories();
        Task<MealApiResponse> GetMeals(string categoryName);
        Task<MeailDetailApiResponse> GetMealDetail(string mealId);
    }
}

