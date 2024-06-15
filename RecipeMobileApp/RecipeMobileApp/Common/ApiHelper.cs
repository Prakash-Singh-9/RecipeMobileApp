using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RecipeMobileApp.Common
{
	public class ApiHelper : IApiHelper
    {
        private readonly IClientHelper _clientHelper;
        public ApiHelper(IClientHelper clientHelper)
        {
            this._clientHelper = clientHelper;
        }

        public async Task<HttpResponseMessage> InvokeGetAPI(string apiName)
        {
            using (var client = _clientHelper.GetClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Add("Connection", "close");
                return await client.GetAsync(apiName);
            }
        }

        public Task<HttpResponseMessage> InvokePostAPI<T>(string apiName, T body)
        {
            throw new NotImplementedException();
        }
    }
}

