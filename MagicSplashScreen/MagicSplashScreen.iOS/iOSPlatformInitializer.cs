using System;
using System.Threading.Tasks;

namespace MagicSplashScreen.iOS
{
    /// <summary>
    /// iOS Platform Initializer
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class iOSPlatformInitializer : IPlatformInitializer
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