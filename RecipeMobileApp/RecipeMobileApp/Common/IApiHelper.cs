using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RecipeMobileApp.Common
{
	public interface IApiHelper
	{
        Task<HttpResponseMessage> InvokeGetAPI(string apiName);
        Task<HttpResponseMessage> InvokePostAPI<T>(string apiName, T body);
    }
}

