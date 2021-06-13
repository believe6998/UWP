using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace assigment.Services
{
    class HomeService
    {
        private Adapters.Adaper _adaper = Adapters.Adaper.GetAdaper();
        public async Task<Models.HomePageRoot> GetHomePage()
        {

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_adaper.GetMenuApi); 
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                Models.HomePageRoot home = JsonConvert.DeserializeObject<Models.HomePageRoot>(stringContent);
                return home;
            }
            return null;
        }
    }
}
