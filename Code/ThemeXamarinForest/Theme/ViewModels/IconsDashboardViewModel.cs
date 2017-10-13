using System;
using Prism.Navigation;
using Prism.Commands;

namespace Theme.ViewModels
{
    public class IconsDashboardViewModel : ViewModelBase
    {
        public IconsDashboardViewModel(INavigationService navigationService) : base(navigationService)
        {
            EnterArticlesCommand = new DelegateCommand(EnterArticles);
        }

        public DelegateCommand EnterArticlesCommand { get; set; }
        private void EnterArticles()
        {

        }
    }
}
