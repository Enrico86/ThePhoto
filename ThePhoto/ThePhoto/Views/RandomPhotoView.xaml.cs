using ThePhoto.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RandomPhotoView : ContentPage
    {
        RandomPhotoViewModel vm =
            new RandomPhotoViewModel();
        public RandomPhotoView()
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage(null);
        }
    }
}