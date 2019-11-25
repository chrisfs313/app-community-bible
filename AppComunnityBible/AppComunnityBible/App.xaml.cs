using AppCommunityBible.Data.Context;
using AppCommunityBible.Data.Repositories;
using AppCommunityBible.Views;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace AppCommunityBible
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var container = new UnityContainer();
            container.RegisterType<IBibleContext, BibleContext>();
            container.RegisterType<IBibleRepository, BibleRepository>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));

            MainPage = new MainMasterDetailPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
