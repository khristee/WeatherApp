using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private List<CityWeather> cityWeather = new List<CityWeather>()
            {
                new CityWeather() {CityUniqueCode = "LDN", CityName="London",DateAndTime = DateTime.Parse("2030-01-01 8:00"), TemperatureFahrenheit = 33},
                new CityWeather() {CityUniqueCode = "NYC", CityName="London",DateAndTime = DateTime.Parse("2030-01-01 3:00"), TemperatureFahrenheit = 60},
                new CityWeather() {CityUniqueCode = "PAR", CityName="Paris",DateAndTime = DateTime.Parse("2030-01-01 9:00"), TemperatureFahrenheit = 82}
            };
        public IActionResult Index()
        {
            
            return View(cityWeather);
        }
        [Route("/weather/{cityCode}")]
        public IActionResult CityDetails(string cityCode)
        {
            if (string.IsNullOrEmpty(cityCode))
            {
                return View();
            }

            CityWeather? city = cityWeather.Where(a => a.CityUniqueCode == cityCode).FirstOrDefault();

            return View(city);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}