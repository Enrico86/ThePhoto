using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Food
{
    public class MeatViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public MeatViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("food", "meat");
            });
        }
    }
}
