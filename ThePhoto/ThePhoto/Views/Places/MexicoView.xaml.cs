using ThePhoto.ViewModels.Places;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Places
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MexicoView : ContentPage
    {
        MexicoViewModel vm =
            new MexicoViewModel();
        public MexicoView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("mexico");
        }
    }
}