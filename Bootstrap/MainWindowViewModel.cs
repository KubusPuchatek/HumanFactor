using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using HumanFactor.Helpers;
using UI;
using UI.People;

namespace HumanFactor
{
    public class MainWindowViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;

        private IBasicViewModel _currentPageViewModel;
        private List<IBasicViewModel> _pageViewModels;

        #endregion

        public MainWindowViewModel()
        {
            // Add available pages
            PageViewModels.Add(new PeopleViewModel());

            // Set starting page
            CurrentPageViewModel = PageViewModels[0];
        }

        #region Properties / Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p =>  ChangeViewModel((IBasicViewModel)p),
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
    }
}
