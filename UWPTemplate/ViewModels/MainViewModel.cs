namespace UWPTemplate.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Base;
    using Windows.UI.Xaml.Navigation;

    public class MainViewModel : ViewModelBase
    {
        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return Task.FromResult<object>(null);
        }

        public override Task OnNavigatedTo(NavigationEventArgs args)
        {
            return Task.FromResult<object>(null);
        }

        public override Task OnNavigatingFrom(NavigatingCancelEventArgs args)
        {
            return Task.FromResult<object>(null);
        }
    }
}
