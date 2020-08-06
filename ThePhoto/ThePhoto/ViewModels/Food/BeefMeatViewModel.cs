using Acr.UserDialogs;
using ThePhoto.Utilities;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Food
{
    public class BeefMeatViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public BeefMeatViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("food", "meat", "beef");
            });
        }
    }
}
