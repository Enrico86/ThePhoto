using ThePhoto.ViewModels.Places;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Places
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParisView : ContentPage
    {
        ParisViewModel vm =
           new ParisViewModel();
        public ParisView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("paris");
        }
    }
}