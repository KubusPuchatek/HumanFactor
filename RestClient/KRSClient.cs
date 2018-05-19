using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanFactor
{
    public class KrsClient
    {
        public async void Get()
        {
            var result = await RestClient.Get<RootObject>("https://api-v3.mojepanstwo.pl/dane/krs_podmioty.json?conditions[q]=Bank%20Millennium");
            //return result.ToString();
        }
    }
}
