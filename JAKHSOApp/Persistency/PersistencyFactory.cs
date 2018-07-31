using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using JAKHSOApp.Interfaces;
using  Newtonsoft.Json;

namespace JAKHSOApp.Persistency
{
    public class PersistencyFactory<T>: IPersistancyFactory<T> where T: class 
    {

        #region instance fields
        // Server URL is our web Api URL
        private const string ServerUrl = "http://denmarklogservice20180718012839.azurewebsites.net/";
        public string ApiPrefix = "api/";
        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;
        #endregion

        public async Task<ObservableCollection<T>> Load(string apiId)
        {
            _httpClientHandler = new HttpClientHandler() { UseDefaultCredentials = true };

            using (_httpClient = new HttpClient(_httpClientHandler))
            {
                _httpClient.BaseAddress = new Uri(ServerUrl);
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    Task<HttpResponseMessage> task5 = _httpClient.GetAsync($"{ServerUrl}{ApiPrefix}{apiId}");
                    if (task5 != null)
                    {
                        if (task5.Result.IsSuccessStatusCode)
                        {
                            var task51 = await task5.Result.Content.ReadAsStringAsync();
                            var listt = JsonConvert.DeserializeObject<ObservableCollection<T>>(task51);
                            return listt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    await new MessageDialog(ex.Message).ShowAsync();
                }
                return null;
            }
        }

    }
}
