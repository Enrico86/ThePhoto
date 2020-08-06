using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Places
{
    public class CancunViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public CancunViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("cancun");
            });
        }
    }
}
