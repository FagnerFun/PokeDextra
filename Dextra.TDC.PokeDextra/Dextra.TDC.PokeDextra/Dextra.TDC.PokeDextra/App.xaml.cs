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
            AppCenter.Start("android=b072c627-d797-4798-9e8d-4c6161ae4945;", typeof(Analytics), typeof(Crashes));
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
