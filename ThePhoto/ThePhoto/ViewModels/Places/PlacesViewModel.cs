using Acr.UserDialogs;
using System.Threading.Tasks;
using System.Windows.Input;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Places
{
    public class PlacesViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public PlacesViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("places");
            });
        }
    }
}
