using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using ThePhoto.Models;
using Unsplasharp;
using Xamarin.Forms;

namespace ThePhoto.ViewModels
{
   
    public class FeaturedDetailViewModel
    {
        private string collectionId = "9454911";

        public ICommand BackCommand => new Command(async () => 
        {
            await Shell.Current.DisplayAlert("Back pressed", "BackButton pressed", "OK");
        });
        public ObservableCollection<Photo> PhotosList { get; set; } =
            new ObservableCollection<Photo>();
        public FeaturedDetailViewModel(string _collectionId)
        {
            collectionId = _collectionId;
            Task.Run(async () =>
            {
                await GetPhotos();
            });
        }

        public async Task GetPhotos()
        {
            PhotosList.Clear();
            var client = new UnsplasharpClient(App.ServiceId);
            var photosList = await client.GetCollectionPhotos(collectionId);
            foreach (var photo in photosList)
            {
                var newPhoto = new Photo
                {
                    Url = photo.Urls.Regular,
                    Likes = photo.Likes
                };
                PhotosList.Add(newPhoto);
            }
        }
    }
}
