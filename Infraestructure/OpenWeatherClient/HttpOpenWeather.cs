using Common;
using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.OpenWeatherClient
{
    public class HttpOpenWeather : IOpenWeatherModel
    {
        public async Task<OpenWeather> GetWeatherByCityNameAsync(string city)
        {
            string url = $"{AppSettings.ApiUrl}{city}&units={AppSettings.units}&lang=sp&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenWeather>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<HistoricalWeather.ForeCastInfo> GetWeatherByCoord(double lat, double lon, long dt)
        {
            string url = $"{AppSettings.ApiHistorical}lat={lat}&lon={lon}&dt={dt}&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<HistoricalWeather.ForeCastInfo>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveJson(HistoricalWeather.ForeCastInfo historicalWeather)
        {
            string HWeatherJson = JsonConvert.SerializeObject(historicalWeather, Formatting.Indented);
            File.AppendAllText("HistoricalWeather.json", HWeatherJson);
        }
    }
}
