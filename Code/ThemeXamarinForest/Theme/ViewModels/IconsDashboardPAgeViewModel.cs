using System;
using Prism.Navigation;
using Prism.Commands;
using System.Runtime.InteropServices;
using Xamarin.Forms;

namespace Theme.ViewModels
{
    public class IconsDashboardPageViewModel : ViewModelBase
    {      
        private int _count;
        public int Count
        {
            get { return _count; }
            set { SetProperty(ref _count, value); }
        }

        public DelegateCommand EnterArticlesCommand { get; set; }
        public DelegateCommand EnterNavigationCommand { get; set; }

        public IconsDashboardPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            EnterArticlesCommand = new DelegateCommand(EnterArticles);
            EnterNavigationCommand = new DelegateCommand(EnterNavigation);
        }

        private void EnterArticles()
        {
            Count++;
        }

        private async void EnterNavigation()
        {          
            await this._navigationService.NavigateAsync("HomePage");
        }
    }
}
