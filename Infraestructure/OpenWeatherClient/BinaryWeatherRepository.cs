using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.OpenWeatherClient
{
    public class BinaryWeatherRepository : IWeatherModel
    {
        public RAFContext context;
        public const int SIZE = 100;
        public BinaryWeatherRepository()
        {
            context = new RAFContext("WeatherForeCast", SIZE);
        }
        public void Add(HistoricalWeather t)
        {
            try
            {
                context.Create<HistoricalWeather>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(HistoricalWeather t)
        {
            try
            {
                context.Delete<HistoricalWeather>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public HistoricalWeather GetById(int id)
        {

            try
            {
                return context.Get<HistoricalWeather>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<HistoricalWeather> Read()
        {

            try
            {
                return context.GetAll<HistoricalWeather>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(HistoricalWeather t)
        {
            try
            {
                context.Update<HistoricalWeather>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
