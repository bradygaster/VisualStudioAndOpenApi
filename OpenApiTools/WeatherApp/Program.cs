using System;
using System.Linq;
using System.Net.Http;
using WeatherClient;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Once the server starts, hit any key to call the weather service");
            Console.ReadLine();

            var client = new WeatherServiceClient("http://localhost:5000", new HttpClient());
            client.GetWeatherForecastAsync().Result.ToList().ForEach(x => Console.WriteLine($"{x.Summary} at {x.TemperatureF}"));

            var zipCode = "98052";
            client.GetWeatherForecastByZipCodeAsync(zipCode).Result.ToList().ForEach(x => Console.WriteLine($"The weather in {zipCode} is a {x.Summary} {x.TemperatureF}"));

            Console.WriteLine($"{Environment.NewLine}Called the weather service");
            Console.ReadLine();
        }
    }
}
