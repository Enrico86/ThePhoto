using ThePhoto.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchView : ContentPage
    {
        private SearchViewModel vm;

        public SearchView()
        {
            InitializeComponent();
        }
    }
}