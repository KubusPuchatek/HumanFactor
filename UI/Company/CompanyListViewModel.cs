using System.Threading.Tasks;
using System.Windows.Input;
using HumanFactor;
using UI.Helpers;
using UI.Interface;
using UI.Shell;

namespace UI.Company
{
    public class CompanyListViewModel : NavigableViewModel, IBasicViewModel
    {
        private ShellViewModel shell => new ShellViewModel();
        public ICommand ChangeTExtCommand
        {
            get
            {
                return _changeTExtCommand ?? (_changeTExtCommand = new RelayCommand(async o => { await Search(); }, o => true));

            }

        }

        public ICommand SelectedCommand
        {
            get
            {
                return _selectedCommand ?? (_selectedCommand = new RelayCommand(async o =>
                {
                    Broker.InvokeNavigationChanged(new HumanFactorNavigationChangedArgs
                    {
                        ViewModel = new CompanyListViewModel()
                    });
                }, o => true));
            }
        }

        private CompanyModel _companies;
        private string _name2;
        private ICommand _changeTExtCommand;
        private ICommand _selectedCommand;
        private DataObject _selectedPerson;
        private readonly ICommand _searchCommand;
        public string Name => "People";

        public string Name2
        {
            get => _name2;
            set { _name2 = value; OnPropertyChanged("Name2");}
        }

        public CompanyModel Companies
        {
            get => _companies;
            set
            {
                _companies = value;
                OnPropertyChanged("Companies");
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                
                return new RelayCommand(async o => { await Search(); }); ;
            }
        }

        private async Task Search()
        {
            var krs = new KrsClient();
            Companies = new CompanyModel();
            Companies.RootObject = await krs.GetCompaniesList(Name2);
        }

        public DataObject SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value; 
                OnPropertyChanged("SelectedPerson");
                Broker.InvokeNavigationChanged(new HumanFactorNavigationChangedArgs
                {
                    ViewModel = new CompanyViewModel(_selectedPerson) 
                });
            }
        }

        public CompanyListViewModel()
        {
/*            Scrapper.FindOnSite("https://www.goldenline.pl/firmy", "Orange");
            Scrapper.FindGoldenLineEmployerRating("Brand 24");
            var googleSearch = new GoogleSearch();
            googleSearch.Find("Brand 24");*/
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
