using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HumanFactor;
using UI.Helpers;

namespace UI.People
{
    public class PeopleViewModel: ObservableObject, IBasicViewModel
    {
        public ICommand ChangeTExtCommand
        {
            get
            {
                return _changeTExtCommand ?? (_changeTExtCommand = new RelayCommand(async o =>
                {
                    var krs = new KrsClient();
                    People = new PersonModel();
                    People.RootObject = await krs.Get(Name2);
                }, o => true));

            }

        }

        private PersonModel _people;
        private string _name2;
        private ICommand _changeTExtCommand;
        public string Name => "People";

        public string Name2
        {
            get => _name2;
            set { _name2 = value; OnPropertyChanged("Name2");}
        }

        public PersonModel People
        {
            get => _people;
            set
            {
                _people = value;
                OnPropertyChanged("People");
            }
        }

        public PeopleViewModel()
        {
            Name2 = "Jeden";
        }
    }
}
