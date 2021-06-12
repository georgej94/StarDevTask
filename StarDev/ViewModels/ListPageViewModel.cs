using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using StarDev.Interfaces;
using StarDev.Models;
using StarDev.Views;
using Xamarin.Forms;

namespace StarDev.ViewModels
{
    public class ListPageViewModel : BaseViewModel
    {
        private readonly ILocationService _locationService;
        private readonly INavigationService _navigationService;

        public ListPageViewModel(INavigationService navigationService, ILocationService locationService)
        {
            _navigationService = navigationService;
            _locationService = locationService;

            Task.Run(() => LoadLocations());
        }

        private bool _loading = true;
        public bool Loading
        {
            get => _loading;
            set => OnPropertyChanged(ref _loading, value);
        }

        private List<Location> _locations;
        public List<Location> Locations
        {
            get => _locations;
            set => OnPropertyChanged(ref _locations, value);
        }

        private Location _selectedLocation;
        public Location SelectedLocation
        {
            get => _selectedLocation;
            set
            {
                OnPropertyChanged(ref _selectedLocation, value);

                if (_selectedLocation == null)
                    return;

                SelectedCommand.Execute(SelectedLocation);

                OnPropertyChanged(ref _selectedLocation, null);
            }
        }

        public ICommand SelectedCommand => new Command<Location>(async (Location location) => await _navigationService.NavigateTo(new DetailsPage(location)));

        private async Task LoadLocations()
        {
            Loading = true;

            var locations = await _locationService.GetLocations();
            Locations = locations.OrderByDescending(x => x.HeadOffice).ToList();

            Loading = false;

        }
    }
}
