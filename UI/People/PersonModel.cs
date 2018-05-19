using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Helpers;

namespace UI.People
{
    public class PersonModel : ObservableObject
    {
        private string _textOne;

        public string TextOne
        {
            get => _textOne;

            set
            {
                _textOne = value;
                OnPropertyChanged("TextOne");
            }
        }
    }
}
