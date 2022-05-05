using Appcore.IServices;
using Common;
using Domain.Entities;
using ExamenApiProg2.UserControls;
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

namespace ExamenApiProg2.Forms
{
    public partial class FrmApi : Form
    {
        string ciudad;
        double lat, lon;
        //int dt;
        long dt = DateTimeOffset.Now.ToUnixTimeSeconds();
        public HttpOpenWeather httpOpenWeather;
        public OpenWeather openWeather;
        public HistoricalWeather.ForeCastInfo historicalWeather;
        public IWeatherServices weatherServices;
        public FrmApi(IWeatherServices WeatherServices)
        {
            httpOpenWeather = new HttpOpenWeather();
            this.weatherServices = WeatherServices;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ciudad = cmbCity.SelectedItem.ToString();
                Task.Run(Request).Wait();

                lat = openWeather.Coord.Lat;
                lon = openWeather.Coord.Lon;
                Task.Run(Request2).Wait();

                if (openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpenWeather.");
                }

                WeatherPanel weatherPanel = new WeatherPanel(weatherServices);
                weatherPanel.lblCity.Text = ciudad;
                weatherPanel.lblTemp.Text = (historicalWeather.current.temp-273.15).ToString() + "C";
                weatherPanel.lblWeather.Text = historicalWeather.current.weather[0].main;
                weatherPanel.picIcon.ImageLocation = $"{AppSettings.ApiIcon}" + openWeather.Weather[0].Icon + ".png";
                flpMain.Controls.Add(weatherPanel);

            }
            catch (Exception)
            {

            }
        }

        public async Task Request()
        {
            openWeather = await httpOpenWeather.GetWeatherByCityNameAsync(ciudad);
        }

        public async Task Request2()
        {
            historicalWeather = await httpOpenWeather.GetWeatherByCoord(lat, lon, dt);
        }

        private void FrmApi_Load(object sender, EventArgs e)
        {
            string fileName = "NicaraguaCitys.json";
            string json = File.ReadAllText(fileName);
            List<JsonCity> cities = new List<JsonCity>();
            cities = JsonConvert.DeserializeObject<List<JsonCity>>(json);
            foreach (JsonCity jCity in cities)
            {
                cmbCity.Items.Add(jCity.City);
            }
        }

        public class JsonCity
        {
            public int Id { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
        }

        private void btnDatagridView_Click(object sender, EventArgs e)
        {
            FrmDatagridView frmDatagridView = new FrmDatagridView(weatherServices);
            frmDatagridView.ShowDialog();
        }
    }
}
