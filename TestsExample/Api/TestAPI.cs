using Newtonsoft.Json;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using TestFramework.API.ResponseModels;
using TestsFramework.Api.ResponseModels;

namespace TestsExample
{
    [Category("Smoke")]
    public class TestAPI : BaseTestAPI
    {
        [Test]
        public async Task GetItem()
        {
            var item = await GetAsync<ProductResponse>("https://rozetka.com.ua/api/product-api/v4/goods/get-main?front-type=xl&country=UA&lang=ru&goodsId=4719078");

            var datass = item.data.ToString();

            Assert.IsNotNull(item);
        }

        [Test]
        
        public async Task PostVideoGame()
        {
            var game = new VideoGame { category = "sd", id = new Random().Next(1, 10099), name = "sad", rating = "8", releaseDate = DateTime.Now, reviewScore = 9 };

           var response =  await PostAsync("http://localhost:8081/app/videogames", game);


            Assert.AreEqual(response.status, "Record Added Successfully");

        }
    }
}
