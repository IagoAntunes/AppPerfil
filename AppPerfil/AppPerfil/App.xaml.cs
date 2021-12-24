using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPerfil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppPerfil.Master.Menu();
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
