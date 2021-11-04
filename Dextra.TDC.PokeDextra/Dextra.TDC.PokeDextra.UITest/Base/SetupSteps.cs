using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Dextra.TDC.PokeDextra.UITest.Base
{
    [Binding]
    public class SetupSteps
    {
        [Given("a started app")]
        public void TheMainPageIsDisplayed()
        {
            if (Global.Platform == Platform.iOS)
            {
                Global.App = ConfigureApp.iOS.StartApp();
            }
            else
            {
                Global.App = ConfigureApp
                    .Android
                    .InstalledApp("com.dextra.pokedextra")
                    .PreferIdeSettings()
                    .EnableLocalScreenshots()
                    .StartApp();
            }
        }
    }
}
