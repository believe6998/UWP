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
    class DetailService
    {
        private Adapters.Adaper _adaper = Adapters.Adaper.GetAdaper();
        public async Task<Models.FoodDetail> getFoodDetail(int id)
        {
            // lay data tu api va nap vao MNItems
            HttpClient httpClient = new HttpClient();// day la shipper lay hang 
                                                     //  var response = await httpClient.GetAsync(_adaper.getFoodDetailApi + id); // file_get_content(); // CURL 
            var response = await httpClient.GetAsync(" https://foodgroup.herokuapp.com/api/food/"+id);
       
           if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync(); // day chinh la string json // read content response
                // convert cai string tren thanh 1 object Menu -- php json_decode  js: JSON_parser
                Models.FoodDetail foodDetail = JsonConvert.DeserializeObject<Models.FoodDetail>(stringContent);
                Console.WriteLine(foodDetail);
                return foodDetail ;
            }
            return null;
        }
    }

}
