using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Dextra.TDC.PokeDextra
{
    public partial class App : Application
    {
        private Dictionary<string, string> _logParams = new Dictionary<string, string>();

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            _logParams.Add("Manufacturer", DeviceInfo.Manufacturer);
            _logParams.Add("Model", DeviceInfo.Model);
            _logParams.Add("Version ", DeviceInfo.VersionString);
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=dacfaa84-3430-4f64-94eb-a660220b1034;", typeof(Analytics), typeof(Crashes));
            Analytics.TrackEvent("App iniciado", _logParams);
        }

        protected override void OnSleep()
        {
            Analytics.TrackEvent("App fechado", _logParams);
        }

        protected override void OnResume()
        {
        }
    }
}
