using System;
using RecipeMobileApp.Common;
using System.ComponentModel;
using Xamarin.Forms;
using Autofac;
using RecipeMobileApp.Services;
using RecipeMobileApp.View;

namespace RecipeMobileApp
{
	public class AppLocator
	{
        private static AppLocator _instance;

        public static AppLocator Instance
        {
            get
            {
                return _instance ?? (_instance = new AppLocator());
            }
        }

        private Autofac.IContainer _container;

        public AppLocator()
        {

        }

        public void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ClientHelper>().As<IClientHelper>();
            builder.RegisterType<ApiHelper>().As<IApiHelper>();
            builder.RegisterType<RecipeService>().As<IRecipeService>();
            _container = builder.Build();

            Console.ReadLine();


        }

        public T GetInstance<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}

