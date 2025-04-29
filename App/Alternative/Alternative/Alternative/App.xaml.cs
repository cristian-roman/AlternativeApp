using System;
using Xamarin.Forms;
using Alternative.View;
using Xamarin.Forms.Xaml;

namespace Alternative
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AuthenticationUI());
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
