using Models;
using ServiceContracts;
using System.Security.AccessControl;

namespace Services
{
    public class CityWeatherService : ICityWeatherService
    {
        private List<CityWeather> _cityWeather;
        
        public CityWeatherService(List<CityWeather> cityWeather)
        {
            _cityWeather = new List<CityWeather>()
            {
                new CityWeather() {CityUniqueCode = "LDN", CityName="London",DateAndTime = DateTime.Parse("2030-01-01 8:00"), TemperatureFahrenheit = 33},
                new CityWeather() {CityUniqueCode = "NYC", CityName="London",DateAndTime = DateTime.Parse("2030-01-01 3:00"), TemperatureFahrenheit = 60},
                new CityWeather() {CityUniqueCode = "PAR", CityName="Paris",DateAndTime = DateTime.Parse("2030-01-01 9:00"), TemperatureFahrenheit = 82};
        }

        public List<CityWeather> GetAllWeatherDetails()
        {
            return _cityWeather;
        }

        public CityWeather? GetCityWeather(string cityCode)
        {
            CityWeather? city = _cityWeather.FirstOrDefault(x => x.CityUniqueCode == cityCode);
            return city;
        }
    }
}
