using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsAPI;
using NewsAPI.Models;
#pragma warning disable 1591

namespace CoreAngular.Controllers
{
    [Route("api/[controller]"), Produces("application/json")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public ArticlesResult News(string country, string sources, string category)
        {
            var newsApiClient = new NewsApiClient("4f9333875c98436787fa163b2604664a");
            var query = new TopHeadlinesRequest();
            if (!string.IsNullOrEmpty(country))
            {
                query.Country = Enum.Parse<NewsAPI.Constants.Countries>(country.ToUpper());
            }

            if (!string.IsNullOrEmpty(sources))
            {
                query.Sources = new List<string> { sources };
            }

            if (!string.IsNullOrEmpty(category))
            {
                query.Category = Enum.Parse<NewsAPI.Constants.Categories>(
                    new CultureInfo("en-US", false).TextInfo.ToTitleCase(category));
            }

            return newsApiClient.GetTopHeadlines(query);
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
