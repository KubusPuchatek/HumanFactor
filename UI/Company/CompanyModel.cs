using HumanFactor;
using UI.Helpers;

namespace UI.Company
{
    public class CompanyModel : ObservableObject
    {
        private string _textOne;
        private RootObject _rootObject;

        public string TextOne
        {
            get => _textOne;

            set
            {
                _textOne = value;
                OnPropertyChanged("TextOne");
            }
        }

        public RootObject RootObject
        {
            get => _rootObject;
            set
            {
                _rootObject = value;
                OnPropertyChanged("RootObject");
            }
        }

        public CompanyModel()
        {
            RootObject = new RootObject();
        }
    }
}
