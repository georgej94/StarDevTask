using CommonServiceLocator;
using StarDev.Interfaces;
using StarDev.Services;
using StarDev.Views;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;

namespace StarDev
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<INavigationService, NavigationService>();
            unityContainer.RegisterType<ILocationService, LocationService>();

            var unityServiceLocator = new UnityServiceLocator(unityContainer);
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);

            MainPage = new NavigationPage(new MainPage());
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
