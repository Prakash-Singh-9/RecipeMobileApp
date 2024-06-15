using System;
using System.Threading.Tasks;

namespace RecipeMobileApp.Common
{
	public interface IRoutingService
	{
        Task GoBack();
        Task GoBackModal();
        Task NavigateTo(string route);
    }

}

