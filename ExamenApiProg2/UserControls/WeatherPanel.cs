using Appcore.IServices;
using Common;
using Domain.Entities;
using Infraestructure.OpenWeatherClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenApiProg2.UserControls
{
    public partial class WeatherPanel : UserControl
    {
        public HttpOpenWeather httpOpenWeather;
        public OpenWeather openWeather;
        public HistoricalWeather.ForeCastInfo historicalWeather;
        public IWeatherServices weatherServices;
        public double lat, lon;
        long dt = DateTimeOffset.Now.ToUnixTimeSeconds();

        public WeatherPanel(IWeatherServices WeatherServices)
        {
            httpOpenWeather = new HttpOpenWeather();
            this.weatherServices = WeatherServices;
            InitializeComponent();
        }
        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            Task.Run(Request).Wait();
            Task.Run(Request2).Wait();
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            DateTime day1 = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            DateTime day2 = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();

            DetailsPanel detailsPanel = new DetailsPanel();
            detailsPanel.lblDetails.Text = "Details";
            detailsPanel.lblValue.Text = historicalWeather.current.weather[0].description;
            flpContent.Controls.Add(detailsPanel);

            DetailsPanel detailsPanel1 = new DetailsPanel();
            detailsPanel1.lblDetails.Text = "amanecer";
            day = day.AddSeconds(historicalWeather.current.sunrise).ToLocalTime();
            detailsPanel1.lblValue.Text = day.ToShortTimeString();
            flpContent.Controls.Add(detailsPanel1);

            DetailsPanel detailsPanel2 = new DetailsPanel();
            detailsPanel2.lblDetails.Text = "atardecer";
            day1 = day1.AddSeconds(historicalWeather.current.sunset).ToLocalTime();
            detailsPanel2.lblValue.Text = day1.ToShortTimeString();
            flpContent.Controls.Add(detailsPanel2);

            DetailsPanel detailsPanel3 = new DetailsPanel();
            detailsPanel3.lblDetails.Text = "Wind Speed";
            detailsPanel3.lblValue.Text = historicalWeather.current.wind_speed.ToString() + " Km/h";
            flpContent.Controls.Add(detailsPanel3);

            DetailsPanel detailsPanel4 = new DetailsPanel();
            detailsPanel4.lblDetails.Text = "Pressure";
            detailsPanel4.lblValue.Text = historicalWeather.current.pressure.ToString();
            flpContent.Controls.Add(detailsPanel4);

            DetailsPanel detailsPanel5 = new DetailsPanel();
            detailsPanel5.lblDetails.Text = "Humidity";
            detailsPanel5.lblValue.Text = historicalWeather.current.humidity.ToString() + "%";
            flpContent.Controls.Add(detailsPanel5);

            HourlyPanel hourlyPanel;
            for (int i = 0; i < historicalWeather.hourly.Count; i++)
            {
                double temp;
                int tempint;
                string hoursToString;
                temp = historicalWeather.hourly[i].temp - 273.15;
                day2 = day2.AddSeconds(historicalWeather.hourly[i].dt).ToLocalTime();
                hoursToString = day2.ToShortTimeString();
                tempint = (int)temp;
                hourlyPanel = new HourlyPanel();
                hourlyPanel.label1.Text = hoursToString;
                hourlyPanel.label2.Text = historicalWeather.hourly[i].weather[0].main;
                hourlyPanel.label3.Text = historicalWeather.hourly[i].weather[0].description;
                hourlyPanel.label4.Text = historicalWeather.hourly[i].wind_speed.ToString();
                hourlyPanel.label5.Text = historicalWeather.hourly[i].pressure.ToString();
                hourlyPanel.lblTemp.Text = tempint.ToString() + "C";
                hourlyPanel.WeatherIcon.ImageLocation = $"{AppSettings.ApiIcon}" + historicalWeather.hourly[i].weather[0].icon + ".png";
                flpContent.Controls.Add(hourlyPanel);
            }

            httpOpenWeather.SaveJson(historicalWeather);
            
        }

        public async Task Request()
        {
            openWeather = await httpOpenWeather.GetWeatherByCityNameAsync(lblCity.Text);
        }
        public async Task Request2()
        {
            historicalWeather = await httpOpenWeather.GetWeatherByCoord(lat, lon, dt);
        }
    }
}
