using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Helpers;
using UI.People;

namespace UI.Menu
{
    public class MenuViewModel : ObservableObject
    {
        internal string StringKeyPrefix => "String.Menu.";
        private List<MenuItemModel> _menuItemsList;

        public List<MenuItemModel> MenuItemsList
        {
            get => _menuItemsList;
            set
            {
                _menuItemsList = value;
                OnPropertyChanged("MenuItemsList");
            }
        }

        public MenuViewModel()
        {
            MenuItemsList = new List<MenuItemModel>
            {
                new MenuItemModel
                {
                    Label = "Comapnies"
                },
                new MenuItemModel
                {
                    Label = "People"
                },
                new MenuItemModel
                {
                    Label = "History"
                }
            };
        }


    }
}
