using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IOpenWeatherModel
    {
        Task<OpenWeather> GetWeatherByCityNameAsync(string city);
        Task<HistoricalWeather.ForeCastInfo> GetWeatherByCoord(double lat, double lon, long dt);
        void SaveJson(HistoricalWeather.ForeCastInfo historicalWeather);
        //Task<HistoricalWeather.ForeCastInfo> SaveJsonA();
    }
}
