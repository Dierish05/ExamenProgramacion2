using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.IServices
{
    public interface IWeatherServices : IServices<HistoricalWeather>
    {
        HistoricalWeather GetById(int id);
    }
}
