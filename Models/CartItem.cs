using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment.Models
{
    class CartItem
    {
        public CartItem(int id, string name, string image, string price, int qty, int unitPrice)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.price = price;
            this.qty = qty;
            this.unitPrice = unitPrice;
        }

        public int id { get; set; } 
        public string name { get; set; }
        public string image { get; set; }
        public string price { get; set; }
        public int qty { get; set; }
        public int unitPrice { get; set; }
    }
}
