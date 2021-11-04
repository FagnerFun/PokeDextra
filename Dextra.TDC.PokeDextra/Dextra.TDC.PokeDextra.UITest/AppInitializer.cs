using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Dextra.TDC.PokeDextra.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("com.dextra.pokedextra")
                    .PreferIdeSettings()
                    .EnableLocalScreenshots()
                    .StartApp();
            }

            return ConfigureApp.iOS
                .EnableLocalScreenshots()
                .StartApp();
        }
    }
}