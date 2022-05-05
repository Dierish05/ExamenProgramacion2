using Appcore.IServices;
using Appcore.Services;
using Autofac;
using Domain.Interfaces;
using ExamenApiProg2.Forms;
using Infraestructure.OpenWeatherClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenApiProg2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterType<BinaryWeatherRepository>().As<IWeatherModel>();
            builder.RegisterType<WeatherServices>().As<IWeatherServices>();
            var container = builder.Build();
            Application.Run(new FrmApi(container.Resolve<IWeatherServices>()));
        }
    }
}
