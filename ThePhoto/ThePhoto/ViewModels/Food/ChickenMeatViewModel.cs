using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Food
{
    public class ChickenMeatViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public ChickenMeatViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("food", "meat", "chicken");
            });
        }
    }
}
