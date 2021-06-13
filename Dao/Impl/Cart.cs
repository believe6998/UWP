using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assigment.Dao;
using assigment.Adapters;
using assigment.Models;
using SQLitePCL;
namespace assigment.Dao.Impl
{
    class Cart : CartService
    {
        public bool AddToCart(CartItem item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.SQLiteConnection;
            string sql_txt = "insert into Cart (id,name,image,price,qty) values(?,?,?,?,?)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            statement.Bind(2, item.name);
            statement.Bind(3, item.image);
            statement.Bind(4, item.price);
            statement.Bind(5, item.qty);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;   
        }

        public List<CartItem> GetCart()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.SQLiteConnection;
            string sql_txt = "select * from Cart";
            var statement = sQLiteConnection.Prepare(sql_txt);
            List<CartItem> list = new List<CartItem>();
            while (SQLiteResult.ROW == statement.Step())
            {
                int id = Convert.ToInt32(statement[0]);
                string name = (string)statement[1];
                string image = (string)statement[2];
                string price = (string)statement[3];
                int qty = Convert.ToInt32(statement[4]);
                int unitPrice = Convert.ToInt32(price.Remove(2, 1).Remove(4)) * qty;
                CartItem c = new CartItem(id, name, image, price, qty, unitPrice);
                list.Add(c);
            }
            return list;
        }
        public bool checkItemExist(CartItem checkItem)
        {
            bool result = false;
            List<CartItem> lsCarts = GetCart();
            foreach(CartItem item in lsCarts)
            {
                if(item.id == checkItem.id)
                {
                    result = true; break;
                }
            }
            return result;
        }
        public CartItem getItemById (int id)
        {
            List<CartItem> lsCarts = GetCart();
            foreach (CartItem item in lsCarts)
            {
                if(item.id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public bool RemoveItem(CartItem item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.SQLiteConnection;
            string sql_txt = "delete from cart where id= ?";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }
        public bool UpdateCart(CartItem item, int qty)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.SQLiteConnection;
            string sql_txt = "update cart set qty = ? where id= ?";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, qty);
            statement.Bind(2, item.id);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }
        public bool ClearCart()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.SQLiteConnection;
            string sql_txt = "delete from cart";
            var statement = sQLiteConnection.Prepare(sql_txt);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }
    }
}
