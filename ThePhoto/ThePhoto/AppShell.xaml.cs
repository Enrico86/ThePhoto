using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ThePhoto.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {

        public ICommand HelpCommand => new Command(async () => await Launcher.OpenAsync(new Uri("https://academiadotnet.teachable.com")));
        public ICommand LuckyCommand => new Command(async () =>
        {
            await Shell.Current.GoToAsync("featuredView");
        });

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("featuredDetail", typeof(FeaturedDetailView));
        }

        protected async override void OnNavigated(ShellNavigatedEventArgs args)
        {
            base.OnNavigated(args);
            string source = args.Source.ToString();
            string previous = args.Previous!=null? args.Previous.Location.ToString():"";
            string current = args.Current != null ? args.Current.Location.ToString() : "";
            string mensaje = $"Se realizó una {source} desde {previous} hacia {current}";
            await DisplayAlert("Navegación", mensaje, "OK");
            
        }
    }
}