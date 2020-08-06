using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ThePhoto.Models;
using Unsplasharp;
using Xamarin.Forms;

namespace ThePhoto.ViewModels
{
    public class FeaturedViewModel
    {
        public ICommand SelectedItemCommand { get; set; }
        public ObservableCollection<CollectionModel> FeaturedList { get; set; } =
            new ObservableCollection<CollectionModel>();
        public FeaturedViewModel()
        {
            SelectedItemCommand = new Command(async (args) =>
            {
                var item = args as CollectionModel;
                if (item!=null)
                { 
                    await Shell.Current.GoToAsync($"featuredDetail?collectionId={item.CollectionId}");
                }
            });
        }
            
        public async Task LoadCollection()
        {
            FeaturedList.Clear();

            var client = new UnsplasharpClient(App.ServiceId);
            var listFeaturedCollection = await client.ListFeaturedCollections();
            foreach (var collection in listFeaturedCollection)
            {
                var newCollection = new CollectionModel
                {
                    CollectionId = collection.Id,
                    Title = collection.Title,
                    Url = collection.CoverPhoto.Urls.Small,
                    Description = collection.Description,
                    Likes = collection.CoverPhoto.Likes
                };

                FeaturedList.Add(newCollection);
            }
        }
    }
}
