using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Helpers;

namespace UI.Menu
{
    public class MenuItemModel : ObservableObject
    {
        private string _itemName;
        private string _label;

        public string ItemName
        {
            get => _itemName;
            set
            {
                _itemName = value;
                OnPropertyChanged("ItemName");
            }
        }

        public string Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged("Label");
            }
        }
    }
}
