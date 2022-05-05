using Appcore.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Services
{
    public class WeatherServices : BaseServices<HistoricalWeather>, IWeatherServices
    {
        IWeatherModel weatherModel;
        public WeatherServices(IWeatherModel model) : base(model)
        {
            this.weatherModel = model;
        }
        public HistoricalWeather GetById(int id)
        {
            return weatherModel.GetById(id);
        }
    }
}
