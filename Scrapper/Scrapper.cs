using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace HumanFactor
{
    public class Scrapper
    {
        public static bool FindOnSite(string address, string query)
        {
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString(address);

                var positionofQueryOnSite = htmlCode.IndexOf(query, StringComparison.Ordinal);
                if (positionofQueryOnSite != -1)
                {
                    return true;
                }

                return false;
            }
        }

        public static bool FindGoldenLineEmployerRating(string query)
        {
            string endOfSearching =
                "Niestety nie znaleźlismy żadnych firm dla wybranych branż i miejscowości. Spróbuj zmienić kryteria w filtrach obok.";

            var baseAddress = "https://www.goldenline.pl/firmy/";
            var page = 1;

            var notFound = -1;

            using (WebClient client = new WebClient())
            {

                var htmlCode = client.DownloadString(baseAddress);
                var keepSearching = htmlCode.IndexOf(endOfSearching, StringComparison.Ordinal) == notFound;
                var notFoundQuery = htmlCode.IndexOf(query, StringComparison.Ordinal) == notFound;
                var previosSite = "";

                while (notFoundQuery && keepSearching)
                {
                    page++;
                    htmlCode = client.DownloadString(baseAddress+page);
                    notFoundQuery = htmlCode.IndexOf(query, StringComparison.Ordinal) == notFound;
                    keepSearching = htmlCode.IndexOf(endOfSearching, StringComparison.Ordinal) == notFound;
                    keepSearching = keepSearching != false && previosSite != htmlCode;
                    previosSite = htmlCode;
                }

                return notFoundQuery;
            }
        }
    }
}
