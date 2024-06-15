using System;
using System.Collections.Generic;

namespace RecipeMobileApp.Model
{
    public class MealApiResponse
    {
        public List<Meal> meals { get; set; }
    }

    public class Meal
    {
        public string strMeal { get; set; }
        public string strMealThumb { get; set; }
        public string idMeal { get; set; }
    }
}

