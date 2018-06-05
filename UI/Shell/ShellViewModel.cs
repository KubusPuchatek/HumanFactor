using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HumanFactor;
using UI.Company;
using UI.Helpers;
using UI.Interface;

namespace UI.Shell
{

    public class ShellViewModel: NavigableViewModel, INavigableViewModel
    {

        #region Fields

        private ICommand _changePageCommand;

        private IBasicViewModel _currentPageViewModel;
        private List<IBasicViewModel> _pageViewModels;

        #endregion

        public ShellViewModel()
        {
         //   CurrentPageViewModel = CurrentPageViewModel ?? new PeopleViewModel();
            Initialize();

            // Add available pages
            PageViewModels.Add(new CompanyListViewModel());

            // Set starting page
            CurrentPageViewModel = PageViewModels[0];
        }

        private void OnNavigationChanged(object sender, HumanFactorNavigationChangetArgs e)
        {
            if (!PageViewModels.Contains(e.ViewModel))
                PageViewModels.Add(e.ViewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == e.ViewModel);
        }

        #region Properties / Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IBasicViewModel)p),
                        p => p is IBasicViewModel);
                }

                return _changePageCommand;
            }
        }

        public List<IBasicViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IBasicViewModel>();

                return _pageViewModels;
            }
        }

        public IBasicViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        #endregion

        #region Methods

        private void ChangeViewModel(IBasicViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        #endregion

        protected override void SubscribeToEvents()
        {
            Broker.NavigationChanged += OnNavigationChanged;
        }

        protected override void UnsubscribeFromEvents()
        {
        }
    }
}
