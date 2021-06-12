using StarDev.Models;

namespace StarDev.ViewModels
{
    public class DetailsPageViewModel : BaseViewModel
    {
        private Location _location;
        public Location Location
        {
            get => _location;
            set => OnPropertyChanged(ref _location, value);
        }

        public DetailsPageViewModel()
        {
        }
    }
}
