using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ThePhoto.Utilities;
using Xamarin.Forms;

namespace ThePhoto.ViewModels.Food
{
    public class FoodViewModel : BaseViewModel
    {
        public ICommand GenerateCommand { get; set; }
        public FoodViewModel()
        {
            GenerateCommand = new Command(async () =>
            {
                await GetImage("food");
            });
        }
    }
}
