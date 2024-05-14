using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;


class Program
{
    static async Task Main(string[] args)
    {
        var url = $"https://weather.tsukumijima.net/api/forecast/city/400040";

        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }

    }
}

