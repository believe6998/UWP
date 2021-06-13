using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
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
using assigment.Models;
using assigment.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace assigment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Foods : Page
    {

        public Foods()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            var foods = e.Parameter as List<Food>;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            foreach (var food in foods)
            {
                food.price = double.Parse(food.price).ToString("#,###", cul.NumberFormat) + " VND";
            }
         
            foodItems.ItemsSource = foods;
        }

        private void FoodDetail_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var foodId = (int)((ListViewItem)sender).Tag;
            this.Frame.Navigate(typeof(Pages.DetailFood), foodId);
        }
    }
}
