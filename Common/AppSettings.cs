using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class AppSettings
    {
        public static string ApiUrl { get => ConfigurationManager.AppSettings.Get("ApiUrl"); }
        public static string ApiHistorical { get => ConfigurationManager.AppSettings.Get("ApiHistorical"); }
        public static string Token { get => ConfigurationManager.AppSettings.Get("Token"); }
        public static string units { get => ConfigurationManager.AppSettings.Get("Units"); }
        public static string ApiIcon { get => ConfigurationManager.AppSettings.Get("ApiIcon"); }
    }
}
