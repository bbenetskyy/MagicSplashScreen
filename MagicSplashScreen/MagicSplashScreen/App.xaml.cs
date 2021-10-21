using System;
using SimpleInjector;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MagicSplashScreen
{
    public partial class App : Application
    {
        public static readonly Container Container;

        static App()
        {
            Container = new Container();
        }
        
        public App()
        {
            InitializeComponent();

            MainPage = new SplashPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

