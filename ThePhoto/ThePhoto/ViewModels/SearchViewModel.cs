using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ThePhoto.Models;
using Unsplasharp;

namespace ThePhoto.ViewModels
{
    public class SearchViewModel
    {
        public ObservableCollection<Photo> PhotosList { get; set; } =
            new ObservableCollection<Photo>();

        private string _collectionId = "4807737";

        public SearchViewModel()
        {
            Task.Run(async () =>
            {
                await GetPhotos();
            });
        }

        public async Task GetPhotos()
        {
            PhotosList.Clear();
            var client = new UnsplasharpClient(App.ServiceId);
            var photosList = await client.GetCollectionPhotos(_collectionId);
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
