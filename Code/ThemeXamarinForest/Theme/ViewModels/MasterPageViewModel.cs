using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;

namespace Theme.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        public MasterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
