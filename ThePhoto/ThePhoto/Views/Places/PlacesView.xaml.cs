using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePhoto.ViewModels.Places;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto.Views.Places
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacesView : ContentPage
    {
        PlacesViewModel vm =
          new PlacesViewModel();
        public PlacesView()
        {
            InitializeComponent();
            BindingContext = vm;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.GetImage("places");
        }
    }
}