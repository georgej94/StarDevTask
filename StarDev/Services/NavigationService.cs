using System;
using System.Linq;
using System.Threading.Tasks;
using StarDev.Interfaces;
using Xamarin.Forms;

namespace StarDev.Services
{
    public class NavigationService : INavigationService
    {
        private Page CurrentPage => Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

        public async Task NavigateBack()
        {
            await CurrentPage.Navigation.PopAsync();
        }

        public async Task NavigateTo(Page page)
        {
            await CurrentPage.Navigation.PushAsync(page);
        }
    }
}
