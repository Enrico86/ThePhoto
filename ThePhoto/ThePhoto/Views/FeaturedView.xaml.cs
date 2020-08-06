using ThePhoto.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeaturedView : ContentPage
    {
        FeaturedViewModel vm =
            new FeaturedViewModel();
        public FeaturedView()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.LoadCollection();
        }

    }
}