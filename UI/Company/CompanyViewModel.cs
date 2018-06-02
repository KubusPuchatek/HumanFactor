using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanFactor;
using UI.Helpers;

namespace UI.Company
{
    internal class CompanyViewModel : ObservableObject
    {
        private KrsModel _krsCompany;

        internal KrsModel KrsCompany
        {
            get => _krsCompany;
            set
            {
                _krsCompany = value;
                OnPropertyChanged("KrsComapny");
            }
        }

        protected CompanyViewModel(KrsModel company)
        {
            KrsCompany = company;
        }
    }
}
