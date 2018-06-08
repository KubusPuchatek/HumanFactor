using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanFactor;
using UI.Helpers;
using UI.Interface;

namespace UI.Company
{
    internal class CompanyViewModel : ObservableObject, IBasicViewModel
    {
        private DataObject _krsCompany;
        private string _companyDescription;

        public DataObject KrsCompany
        {
            get => _krsCompany;
            set
            {
                _krsCompany = value;
                OnPropertyChanged("KrsCompany");
            }
        }

        public CompanyViewModel(DataObject company)
        {
            KrsCompany = company;
            CompanyDescription = PrepareDescription();


        }

        public string CompanyDescription
        {
            get => _companyDescription;
            set
            {
                _companyDescription = value;
                OnPropertyChanged("CompanyDescription");
            }
        }

        public string Name { get; }

        private string PrepareDescription()
        {
            if (KrsCompany!=null)
            {
                var result = "";

                if (!string.IsNullOrEmpty(KrsCompany.data.data_rejestracji))
                {
                    result += KrsCompany.data.nazwa+" jest firmą działającą na rynku od " + KrsCompany.data.data_rejestracji;
                    
                }

                return result;
            }

            return "Sorry, we couldn't find any data about that company";
        }
    }
}
