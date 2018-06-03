using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HumanFactor;
using UI.Helpers;
using UI.Interface;
using UI.Shell;

namespace UI.People
{
    public class PeopleViewModel: NavigableViewModel, IBasicViewModel
    {
        private ShellViewModel shell => new ShellViewModel();
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

        public ICommand SelectedCommand
        {
            get
            {
                return _selectedCommand ?? (_selectedCommand = new RelayCommand(async o =>
                {
                    Broker.InvokeNavigationChanged(new HumanFactorNavigationChangetArgs
                    {
                        ViewModel = new PeopleViewModel()
                    });
                }, o => true));
            }
        }

        private PersonModel _people;
        private string _name2;
        private ICommand _changeTExtCommand;
        private ICommand _selectedCommand;
        private string _selectedPerson;
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

        public string SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value; 
                OnPropertyChanged("SelectedPerson");
                Broker.InvokeNavigationChanged(new HumanFactorNavigationChangetArgs
                {
                    ViewModel = new PeopleViewModel()
                });
            }
        }

        public PeopleViewModel()
        {
            Name2 = "Jeden";
        }

        protected override void SubscribeToEvents()
        {
        }

        protected override void UnsubscribeFromEvents()
        {
        }
    }
}
