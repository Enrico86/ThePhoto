using System;
using System.Windows.Input;
using ThePhoto.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ThePhoto
{
    public partial class App : Application
    {
        //public const string ServiceId = "dfdc0d47f3e1295d480a779ff0e8a4c0c22fa4f165b5758c731e9b649aa1c065";
        public const string ServiceId = "YVplhT6DhGAVkiaa70esuyWSTsjkh2DTsCgqGdfGmrM";



        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
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
