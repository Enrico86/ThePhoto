using ThePhoto.ViewModels.Food;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Food
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CookiesView : ContentPage
    {
        CookiesViewModel vm =
            new CookiesViewModel();
        public CookiesView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("food", "dessert", "cookies");
        }
    }
}