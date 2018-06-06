using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace HumanFactor
{
    public class GoogleSearch
    {
        public void Find(string query)
        {
            var customSearchService = new CustomsearchService(new BaseClientService.Initializer { ApiKey = Properties.Resources.ApiKey });
            var listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = Properties.Resources.SearchEngineId;
            
            IList<Result> paging = new List<Result>();
            var count = 0;
            while (paging != null)
            {
                listRequest.Start = count * 10 + 1;
                paging = listRequest.Execute().Items;
              
                count++;
            }
        }
    }
}
