using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Food
{
    public class CookiesViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public CookiesViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("food", "dessert", "cookies");
            });
        }
    }
}
