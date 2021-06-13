using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment.Models
{
    public class Data
    {
        public int order_id { get; set; }
    }

    public class CreateOrder
    {
        public string message { get; set; }
        public Data data { get; set; }
    }
}
