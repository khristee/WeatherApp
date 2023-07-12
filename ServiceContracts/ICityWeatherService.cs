using WeatherApp.Models;

namespace ServiceContracts
{
    public interface ICityWeatherService
    {
        List<CityWeather> GetAllWeatherDetails();
        CityWeather? GetCityWeather(string cityCode);
    }
}