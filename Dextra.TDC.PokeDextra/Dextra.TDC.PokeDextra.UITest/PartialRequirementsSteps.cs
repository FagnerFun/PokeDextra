using Dextra.TDC.PokeDextra.UITest.Base;
using NUnit.Framework;
using Xamarin.UITest;

namespace Dextra.TDC.PokeDextra.UITest
{
    [TestFixture(Platform.iOS)]
    [TestFixture(Platform.Android)]
    public partial class PartialRequirementsSteps
    {
        public PartialRequirementsSteps(Platform platform)
        {
            Global.Platform = platform;
        }
    }
}
