using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HumanFactor
{
    public class RestClient
    {
        //public static async Task<UserCredentials> Login(string queryString, object objectToSend)
        //{
        //    try
        //    {
        //        var cookieContainer = new CookieContainer();
        //        using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
        //        {
        //            using (var client = new HttpClient(handler))
        //            {
        //                var serialized = JsonConvert.SerializeObject(objectToSend);
        //                /*string json = "{\"Which\":\"en\"," +
        //                                    "\"Language\":\"en\"}";*/
        //                // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
        //                var httpContent = new StringContent(serialized, Encoding.UTF8, "application/json");

        //                var response = await client.PostAsync(queryString, httpContent);

        //                var responseCookies = cookieContainer.GetCookies(new Uri("http://yachter.cloudapp.net"));

        //                // var Cookie: ss - id = Ld28ax70Us6TmhN8IPv7; ss - pid = qsYl4rET3s3D8dlsrOCu; X - UAId = 15; gsScrollPos =

        //                var ssid = responseCookies["ss-id"].Value;
        //                var sspid = responseCookies["ss-pid"].Value;
        //                var xuaid = responseCookies["X-UAId"].Value;


        //                var tmp = await response.Content.ReadAsStringAsync();


        //                var data = JsonConvert.DeserializeObject<AuthResponseModel>(tmp);


        //                var userCredentials = new UserCredentials
        //                {
        //                    UserId = data.UserId,
        //                    Password = "",
        //                    RememberMe = false,
        //                    Type = UserType.Renter,
        //                    Username = data.UserName,
        //                    SessionId = data.SessionId,
        //                    DisplayName = data.DisplayName,
        //                    Pid = sspid
        //                };

        //                return userCredentials;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public static async Task<T> Get<T>(string queryString, object objectToSend = null)
        {
            try
            {
                var cookieContainer = new CookieContainer();
                using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
                {
                    using (var client = new HttpClient(handler))
                    {
                        if (objectToSend != null)
                        {
                            var serialized = JsonConvert.SerializeObject(objectToSend);
                            /*string json = "{\"Which\":\"en\"," +
                                            "\"Language\":\"en\"}";*/
                            // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
                            var httpContent = new StringContent(serialized, Encoding.UTF8, "application/json");
                        }

                        var response = await client.GetAsync(queryString);
                        /*var responseText = await client.GetStringAsync(queryString);*/

                        var tmp = await response.Content.ReadAsStringAsync();

                        T data = JsonConvert.DeserializeObject<T>(tmp);
                        return data;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //public static async Task<T> Get<T>(string queryString, object objectToSend = null)
        //{
        //    try
        //    {
        //        var cookieContainer = new CookieContainer();
        //        using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
        //        {
        //            using (var client = new HttpClient(handler))
        //            {
        //                var credentials = await App.Database.GetFirsOrDefaultAsync();
        //                if (credentials == null)
        //                {
        //                    throw new Exception("Unauthorized");
        //                }

        //                if (objectToSend != null)
        //                {
        //                    var serialized = JsonConvert.SerializeObject(objectToSend);
        //                    /*string json = "{\"Which\":\"en\"," +
        //                                    "\"Language\":\"en\"}";*/
        //                    // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
        //                    var httpContent = new StringContent(serialized, Encoding.UTF8, "application/json");
        //                }

        //                if (!string.IsNullOrEmpty(credentials.SessionId))
        //                {
        //                    cookieContainer.Add(new Uri(queryString), new Cookie("ss-id", credentials.SessionId));
        //                    cookieContainer.Add(new Uri(queryString), new Cookie("ss-pid", credentials.Pid));
        //                    cookieContainer.Add(new Uri(queryString), new Cookie("X-UAId", credentials.ID.ToString()));
        //                }

        //                var response = await client.GetAsync(queryString);
        //                /*var responseText = await client.GetStringAsync(queryString);*/

        //                var tmp = await response.Content.ReadAsStringAsync();

        //                T data = JsonConvert.DeserializeObject<T>(tmp);
        //                return data;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}


        //public static async Task<T> Post<T>(string queryString, object objectToSend, object credentials)
        //{
        //    try
        //    {
        //        var cookieContainer = new CookieContainer();
        //        using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
        //        {
        //            using (var client = new HttpClient(handler))
        //            {
        //                var serialized = JsonConvert.SerializeObject(objectToSend);
        //                /*string json = "{\"Which\":\"en\"," +
        //                                    "\"Language\":\"en\"}";*/
        //                // Wrap our JSON inside a StringContent which then can be used by the HttpClient class
        //                var httpContent = new StringContent(serialized, Encoding.UTF8, "application/json");

        //                if (!string.IsNullOrEmpty(credentials.SessionId))
        //                {
        //                    cookieContainer.Add(new Uri(queryString), new Cookie("ss-id", credentials.SessionId));
        //                }

        //                var response = await client.PostAsync(queryString, httpContent);

        //                var uri = new Uri(queryString);
        //                uri = new Uri("http://yachter.cloudapp.net");
        //                var responseCookies = cookieContainer.GetCookies(new Uri("http://yachter.cloudapp.net"));

        //                // var Cookie: ss - id = Ld28ax70Us6TmhN8IPv7; ss - pid = qsYl4rET3s3D8dlsrOCu; X - UAId = 15; gsScrollPos =

        //                var ssid = responseCookies["ss-id"].Value;
        //                var sspid = responseCookies["ss-pid"].Value;
        //                var xuaid = responseCookies["X-UAId"].Value;


        //                var tmp = await response.Content.ReadAsStringAsync();


        //                T data = JsonConvert.DeserializeObject<T>(tmp);
        //                return data;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
