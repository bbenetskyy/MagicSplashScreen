using System;
using System.Threading.Tasks;

namespace MagicSplashScreen.Droid
{
    /// <summary>
    /// Android Platform Initializer
    /// </summary>
    public class AndroidPlatformInitializer: IPlatformInitializer
    {
        /// <summary>
        /// Perform all platform specific initialisation
        /// </summary>
        public Task Initialize()
        {
            //initialize all nuget packages that is possible initialize later
            return Task.Delay(TimeSpan.FromSeconds(5));
        }
    }
}