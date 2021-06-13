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
    class CategoryService
    {
        private Adapters.Adaper adapter = Adapters.Adaper.GetAdaper();
        public async Task<Models.CategoryRoot>  getCategoryPage(int id)
        {
            HttpClient httpclient = new HttpClient();
            var response = await httpclient.GetAsync(adapter.getCategoryApi + id);
            return (response.StatusCode == HttpStatusCode.OK) ?
                                        JsonConvert.DeserializeObject<Models.CategoryRoot>(await response.Content.ReadAsStringAsync())
                                        : null;
        }
    }
}
