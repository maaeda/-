using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiUrl = "https://weather.tsukumijima.net/api/forecast/city/070010";
            await DisplayWeather(apiUrl);
        }

        static async Task DisplayWeather(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                var weatherData = JObject.Parse(response);

                Console.WriteLine("地域: " + weatherData["location"]["district"]);
                Console.WriteLine("天気: " + weatherData["forecasts"][0]["telop"]);
                Console.WriteLine("最高気温: " + weatherData["forecasts"][0]["temperature"]["max"]["celsius"] + "℃");
                Console.WriteLine("最低気温: " + weatherData["forecasts"][0]["temperature"]["min"]["celsius"] + "℃");
            }
        }
    }
}
