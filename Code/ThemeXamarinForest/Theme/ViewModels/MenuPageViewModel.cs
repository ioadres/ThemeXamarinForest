using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using Theme.Models;
using System.Reflection;
using System.Collections.ObjectModel;

namespace Theme.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        public ObservableCollection<MenuItem> MenuList
        {
            get;
            set;
        }
        public MenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "MenuPage";
            MenuList = new ObservableCollection<MenuItem>();
            LoadMenu();
        }

        private void LoadMenu() {
           
            MenuList.Add(new MenuItem() {
                Icon = "&#xf2b9;",
                Title ="Document"
            });
            MenuList.Add(new MenuItem()
            {
                Icon = "&#xf2bc;",
                Title = "Card"
            });
            MenuList.Add(new MenuItem()
            {
                Icon = "&#xf042;",
                Title = "Ajust"
            });
            MenuList.Add(new MenuItem()
            {
                Icon = "&#xf016;",
                Title = "Arrow"
            });
        }
    }
}
