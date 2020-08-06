using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Places
{
    public class EgyptViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public EgyptViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("egypt");
            });
        }
    }
}
