using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using assigment.Dao.Impl;
using assigment.Models;
using assigment.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace assigment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Payment : Page
    {
        public Payment()
        {
            this.InitializeComponent();
            Cart cart = new Cart();
            var lsCartItems = cart.GetCart();
            var totalPrice = 0;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            foreach (var item in lsCartItems)
            {
                if (item.name.Length >= 12)
                {
                    item.name =  item.name.Remove(12) + "...";
                }

                totalPrice += Int32.Parse(item.unitPrice);
                item.unitPrice = double.Parse(item.unitPrice).ToString("#,###", cul.NumberFormat) + " VND";
            }
            MNItems.ItemsSource = lsCartItems;
            TotalPrice.Text = "Tổng tiền: " + double.Parse(totalPrice.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
            if (lsCartItems.Count == 0)
            {
                TotalPrice.Text = "";
                NoCart.Text = "Bạn chưa chọn sản phẩm nào";
            }
         
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            OrderService orderService = new OrderService();
            Cart cart = new Cart();
            CreateOrder co = await orderService.CreateOrder(cart.GetCart());
            result.Text = "Đặt hàng thành công!!!!";
            MNItems.ItemsSource = null;
            TotalPrice.Text = "";
        }
    }
}
