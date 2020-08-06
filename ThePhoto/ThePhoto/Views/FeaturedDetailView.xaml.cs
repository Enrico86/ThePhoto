using ThePhoto.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("CollectionId", "collectionId")]
    public partial class FeaturedDetailView : ContentPage
    {



        private FeaturedDetailViewModel vm;
        private string collectionId;

        public string CollectionId
        {
            get => collectionId;
            set
            {
                collectionId = value;
                vm = new FeaturedDetailViewModel(collectionId);
                BindingContext = vm;
            }
        }

        public FeaturedDetailView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}