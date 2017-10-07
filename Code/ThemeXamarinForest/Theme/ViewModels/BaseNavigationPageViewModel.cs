using System;
using Prism.Navigation;

namespace Theme.ViewModels
{
	public class BaseNavigationPageViewModel : ViewModelBase
	{
		public BaseNavigationPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{

		}
	}
}
