using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppIntermedio369.View;

namespace AppIntermedio369
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage(new VPaginaPrincipal());
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
