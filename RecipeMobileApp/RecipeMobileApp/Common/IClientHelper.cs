using System;
using System.Net.Http;

namespace RecipeMobileApp.Common
{
	public interface IClientHelper
	{
        HttpClient GetClient();
    }
}

