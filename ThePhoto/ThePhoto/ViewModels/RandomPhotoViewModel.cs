using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels
{
    public class RandomPhotoViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public RandomPhotoViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage(null);
            });
        }
    }
}
