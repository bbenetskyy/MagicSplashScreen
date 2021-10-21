using System;
using System.Threading.Tasks;

namespace MagicSplashScreen.Droid
{
    public class AndroidPlatformInitializer: IPlatformInitializer
    {
        public Task Initialize()
        {
            //initialize all nuget packages that is possible initialize later
            return Task.Delay(TimeSpan.FromSeconds(5));
        }
    }
}