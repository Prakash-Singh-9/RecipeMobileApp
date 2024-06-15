using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RecipeMobileApp.Common
{
    public class ClientHelper : IClientHelper
	{
        public ClientHelper() { }
        public HttpClient GetClient()
        {
            return new HttpClient();
        }
    }
}

