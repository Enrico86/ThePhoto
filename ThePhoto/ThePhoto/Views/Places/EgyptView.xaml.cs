using ThePhoto.ViewModels.Places;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Places
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EgyptView : ContentPage
    {
        EgyptViewModel vm =
           new EgyptViewModel();
        public EgyptView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("egypt");
        }
    }
}