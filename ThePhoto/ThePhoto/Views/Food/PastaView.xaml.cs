using ThePhoto.ViewModels.Food;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Food
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PastaView : ContentPage
    {
        PastaViewModel vm =
            new PastaViewModel();
        public PastaView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("food", "pasta");
        }
    }
}