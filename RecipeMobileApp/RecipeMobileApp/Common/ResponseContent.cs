using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RecipeMobileApp.Common
{
    public partial class ResponseContent<T>
    {
        public static async Task<T> ResponseContentAsync(HttpResponseMessage httpResponseMessage)
        {
            try
            {
                T responseconent;
                string apiResponseString = await httpResponseMessage.Content.ReadAsStringAsync();
                responseconent = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(apiResponseString);

                return responseconent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
    }
}

