using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Acr.UserDialogs;
using ThePhoto.Models;
using ThePhoto.Utilities;

namespace ThePhoto.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private Photo _photo;
        private bool _isTitleVisible;

        public Photo Photo
        {
            get
            {
                return _photo;
            }
            set
            {
                _photo = value;
                OnPropertyChanged();
            }
        }

        public bool IsTitleVisible
        {
            get => _isTitleVisible;
            set
            {
                _isTitleVisible = value;
                OnPropertyChanged();
            }
        }

        public async Task GetImage(params string[] terms)
        {
            UserDialogs.Instance.ShowLoading("Searching");


            Photo = await ImageHelper.GeneratePhotoAsync(terms);

            if (Photo.Title == null)
            {
                IsTitleVisible = false;
            }
            else
            {
                IsTitleVisible = true;
            }

            UserDialogs.Instance.HideLoading();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
