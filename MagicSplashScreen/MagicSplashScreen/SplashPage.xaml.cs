using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MagicSplashScreen
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            BindingContext = true;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ = Task.Run(async () =>
            {
                //initialize all IoC Dependencies, this may be void or a Task Method
                await SetupDependencies();
                Device.BeginInvokeOnMainThread(() => Application.Current.MainPage = new MainPage());
            });
        }

        private Task SetupDependencies() => Task.WhenAll(
            //Local initialization of shared things moved from App.xaml.cs here
            // Replace this Completed Task with your iOS Registration; Global Hard Stuff initalisatioin
            Task.CompletedTask,
            // Platform specific initialisation
            App.Container.GetInstance<IPlatformInitializer>().Initialize()
        );
    }
}

