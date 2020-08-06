using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Places
{
    public class ParisViewModel: BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public ParisViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("paris");
            });
        }
    }
}
