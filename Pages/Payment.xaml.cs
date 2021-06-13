using System;
using System.Collections.Generic;
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
            MNItems.ItemsSource = lsCartItems;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            OrderService orderService = new OrderService();
            Cart cart = new Cart();
            CreateOrder co = await orderService.CreateOrder(cart.GetCart());
            result.Text = "Đặt hàng thành công";
        }
    }
}
