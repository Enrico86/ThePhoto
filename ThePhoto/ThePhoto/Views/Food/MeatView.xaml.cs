using ThePhoto.ViewModels.Food;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Food
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeatView : ContentPage
    {
        MeatViewModel vm =
            new MeatViewModel();
        public MeatView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("food", "meat");
        }
    }
}