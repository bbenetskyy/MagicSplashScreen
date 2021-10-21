using System;
using System.Threading.Tasks;

namespace MagicSplashScreen.iOS
{
    // ReSharper disable once InconsistentNaming
    public class iOSPlatformInitializer : IPlatformInitializer
    {
        public Task Initialize()
        {
            //initialize all nuget packages that is possible initialize later
            return Task.Delay(TimeSpan.FromSeconds(5));
        }
    }
}