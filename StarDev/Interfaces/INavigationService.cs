using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StarDev.Interfaces
{
    public interface INavigationService
    {
        Task NavigateTo(Page page);
        Task NavigateBack();
    }
}
