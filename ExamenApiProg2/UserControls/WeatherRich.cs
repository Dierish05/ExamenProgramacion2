using Appcore.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenApiProg2.UserControls
{
    public partial class WeatherRich : UserControl
    {
        IWeatherServices weatherServices;
        public WeatherRich(IWeatherServices WeatherServices)
        {
            this.weatherServices = WeatherServices;
            InitializeComponent();
        }
    }
}
