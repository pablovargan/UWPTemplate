namespace UWPTemplate.Views.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ViewModels.Base;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    public class PageBase : Page 
    {
        private ViewModelBase _vm;
        private Frame splitViewFrame;

        public Frame SplitViewFrame
        {
            get { return this.splitViewFrame; }
            set
            {
                this.splitViewFrame = value;

                if (_vm == null)
                {
                    _vm = (ViewModelBase)this.DataContext;
                }

                _vm.SetSplitFrame(this.splitViewFrame);
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            _vm = (ViewModelBase)this.DataContext;
            _vm.SetAppFrame(this.Frame);
            _vm.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            _vm.OnNavigatedFrom(e);
        }
    }
}
