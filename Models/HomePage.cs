using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment.Models
{
  
         class HomepageData
        {
            public int id { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string description { get; set; }
            public string price { get; set; }
        }

        class HomePageRoot
        {
            public string message { get; set; }
            public List<HomepageData> data { get; set; }
        }
    
}
