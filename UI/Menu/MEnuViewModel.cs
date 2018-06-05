using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HumanFactor;
using UI.Company;
using UI.Helpers;

namespace UI.Menu
{
    public class MenuViewModel : NavigableViewModel
    {
        internal string StringKeyPrefix => "String.Menu.";
        private List<MenuItemModel> _menuItemsList;
        private MenuItemModel _selectedItem;

        public List<MenuItemModel> MenuItemsList
        {
            get => _menuItemsList;
            set
            {
                _menuItemsList = value;
                OnPropertyChanged("MenuItemsList");
            }
        }

        public MenuItemModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                switch (value.Label)
                {
                    case "Companies":
                        Broker.InvokeNavigationChanged(new HumanFactorNavigationChangedArgs
                        {
                            ViewModel = new CompanyListViewModel()
                        });
                        break;

                    case "People":
                        Broker.InvokeNavigationChanged(new HumanFactorNavigationChangedArgs
                        {
                            ViewModel = new CompanyListViewModel()
                        });
                        break;

                    case "History":
                        Broker.InvokeNavigationChanged(new HumanFactorNavigationChangedArgs
                        {
                            ViewModel = new CompanyListViewModel()
                        });
                        break;
                }
                OnPropertyChanged("SelectedItem");
                _selectedItem = value;
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


        protected override void SubscribeToEvents()
        {
            
        }

        protected override void UnsubscribeFromEvents()
        {
        }
    }
}
