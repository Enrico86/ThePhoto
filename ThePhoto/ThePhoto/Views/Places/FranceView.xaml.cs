using ThePhoto.ViewModels.Places;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Places
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FranceView : ContentPage
    {
        FranceViewModel vm =
           new FranceViewModel();
        public FranceView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("france");
        }
    }
}