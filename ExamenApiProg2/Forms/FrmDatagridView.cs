using Appcore.IServices;
using ExamenApiProg2.UserControls;
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
    public partial class FrmDatagridView : Form
    {
        IWeatherServices weatherServices;
        public FrmDatagridView(IWeatherServices WeatherServices)
        {
            this.weatherServices = WeatherServices;
            InitializeComponent();
        }

        private void FrmDatagridView_Load(object sender, EventArgs e)
        {
            //WeatherdatagridView weatherDatagridView = new WeatherdatagridView(weatherServices);
            //weatherDatagridView.dataGridView1.DataSource = null;
            //weatherDatagridView.dataGridView1.DataSource = weatherServices.Read();

            WeatherRich weatherRich = new WeatherRich(weatherServices);
            weatherRich.richTextBox1.Text = File.ReadAllText("HistoricalWeather.json");
            flowLayoutPanel1.Controls.Add(weatherRich);
        }
    }
}
