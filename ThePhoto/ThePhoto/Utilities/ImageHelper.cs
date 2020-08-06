using System.Linq;
using ThePhoto.Models;
using Unsplasharp;

namespace ThePhoto.Utilities
{
    public static class ImageHelper
    {
        public static async System.Threading.Tasks.Task<Photo> GeneratePhotoAsync(params string[] searchTerms)
        {
            string terms = string.Empty;
            if (searchTerms != null)
            {
                foreach (var term in searchTerms)
                {
                    terms += term;
                    terms += ",";
                }
                terms = terms.Substring(0, terms.Length - 1);
            }

            var client = new UnsplasharpClient(App.ServiceId);
            var photos = await client.GetRandomPhoto(UnsplasharpClient.Orientation.Landscape, false, query: terms);
            if (photos.Count > 0)
            {
                var first = photos.FirstOrDefault();
                if (first != null)
                {
                    var photo = new Photo
                    {
                        Url = first.Urls.Regular,
                        Title = first.Description,
                        Likes = first.Likes
                    };

                    return photo;
                }
            }
            return null;
        }
    }
}