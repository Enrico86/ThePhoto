using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Places
{
    public class CairoViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public CairoViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("cairo");
            });
        }
    }
}
