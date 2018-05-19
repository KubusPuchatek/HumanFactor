using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanFactor
{
    public class KrsClient
    {
        public async Task<RootObject> Get(string name)
        {
            var result = await RestClient.Get<RootObject>("https://api-v3.mojepanstwo.pl/dane/krs_podmioty.json?conditions[q]="+name);
            return result;
        }
    }
}
