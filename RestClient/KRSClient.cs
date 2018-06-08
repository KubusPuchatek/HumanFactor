using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanFactor
{
    public class KrsClient
    {
        public async Task<RootObject> GetCompaniesList(string name)
        {
            var result = await RestClient.Get<RootObject>("https://api-v3.mojepanstwo.pl/dane/krs_podmioty.json?conditions[q]="+name);
            return result;
        }

        public async Task<RootObject> GetCompanyDetails(string id)
        {
            var result = await RestClient.Get<RootObject>("https://api-v3.mojepanstwo.pl/dane/krs_podmioty/"+id+ ".json?layers[]=dzialalnosci&layers[]=firmy&layers[]=wspolnicy");
            return result;
        }
    }
}
