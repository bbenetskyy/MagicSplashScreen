using System.Threading.Tasks;

namespace MagicSplashScreen
{
    /// <summary>
    /// Platform Initializer
    /// </summary>
    public interface IPlatformInitializer
    {
        /// <summary>
        /// Perform all platform specific initialisation
        /// </summary>
        /// <returns>awaitable task</returns>
        Task Initialize();
    }
}