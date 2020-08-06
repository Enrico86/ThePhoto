using System.Collections.Generic;
using System.Threading.Tasks;
using ThePhoto.Models;
using Unsplasharp;

namespace ThePhoto.Search
{
    public class SearchHelper
    {
        public async Task<List<CollectionModel>> GetSearchData()
        {
            List<CollectionModel> collectionList =
                new List<CollectionModel>();

            var client = new UnsplasharpClient(App.ServiceId);
            var collections = await client.ListCollections(1, 25);
            foreach (var collection in collections)
            {
                var newCollection = new CollectionModel
                {
                    CollectionId = collection.Id,
                    Title = collection.Title,
                    Url = collection.CoverPhoto.Urls.Small,
                    Description = collection.Description,
                    Likes = collection.CoverPhoto.Likes
                };

                collectionList.Add(newCollection);
            }

            return collectionList;
        }
    }
}