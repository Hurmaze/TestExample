using Microsoft.AspNetCore.WebUtilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestFramework.API.ResponseModels;
using TestFramework.Helpers;

namespace TestsExample
{
    public class BaseTestAPI
    {
        public static async Task<T> GetAsync<T>(string url)
        {
            using var client = new HttpClient();
            var message = await client.GetAsync(url);

            return JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
        }

        public static async Task<T> GetAsync<T>(string url, object model)
        {
            using var client = new HttpClient();

            var message = await client.GetAsync($"{url}?{model.ToQueryString()}");
                    
            return JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
        }

        public static async Task<T> GetAsync<T>(string url, Dictionary<string, string> model)
        {
            using var client = new HttpClient();
            var message = await client.GetAsync(QueryHelpers.AddQueryString(url, model));
            return JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
        }

        public static async Task<StatusRes> PostAsync<T>(string url, T model)
        {
               

            using var client = new HttpClient();

            var company = JsonConvert.SerializeObject(model);
            var requestContent = new StringContent(company, Encoding.UTF8, "application/json");

          var res =   await client.PostAsync(url, requestContent);
            return JsonConvert.DeserializeObject<StatusRes>(await res.Content.ReadAsStringAsync());
        }
    }
}
