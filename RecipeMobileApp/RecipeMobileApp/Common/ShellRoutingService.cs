using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RecipeMobileApp.Common
{
	public class ShellRoutingService :IRoutingService
	{
        private static ShellRoutingService _instance;

        public static ShellRoutingService Instance
        {
            get
            {
                return _instance ?? (_instance = new ShellRoutingService());
            }
        }

        public ShellRoutingService()
        {
        }

        public Task NavigateTo(string route)
        {
            return Shell.Current.GoToAsync(route);
        }

        public Task GoBack()
        {
            return Shell.Current.Navigation.PopAsync();
        }

        public void RemovePage(Page page)
        {
            Shell.Current.Navigation.RemovePage(page);
        }

        public Task GoBackModal()
        {
            return Shell.Current.Navigation.PopModalAsync();
        }
    }
}

