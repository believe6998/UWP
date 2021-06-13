using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment.Adapters
{
    class Adaper
    {
        private string baseURL = "https://foodgroup.herokuapp.com";

        // singleton pattern

        private static Adaper instance;

        private Adaper()
        {
        }

        public static Adaper GetAdaper()
        {
            if (instance == null)
            {
                instance = new Adaper();
            }
            return instance;
        }

        public string GetMenuApi
        {
            get => String.Format(baseURL + "/api/today-special");
        }
        public string getCategoryApi
        {
            get => String.Format(baseURL+ "/api/category/");
        }
        public string getFoodDetailApi
        {
            get => String.Format(baseURL + "/api/food/");
        }
        public string GetCreateOrderApi
        {
            get => String.Format(baseURL + "/api/create-order");
        }
    }
}
