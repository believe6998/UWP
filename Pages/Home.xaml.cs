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
using assigment.Models;
using assigment.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace assigment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            GetTodaySpecials();
        }

        public async void GetTodaySpecials() // bao hieu rang se su dung cu phap xu ly bat dong bo hoa
        {
            HomeService service = new HomeService();
            HomePageRoot home = await service.GetHomePage();
            var foods = new List<HomepageData>();
            if (home != null)
            {
                foods = home.data;
                foreach (var food in foods)
                {
                    var cul = CultureInfo.GetCultureInfo("vi-VN");
                    food.price = double.Parse(food.price).ToString("#,###", cul.NumberFormat) + " VND";
                }
             
                FoodItems.ItemsSource = foods;
            }
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
            // Title.Text = msg;
        }
        private void ResName_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var foodId = (int)((ListViewItem)sender).Tag;
            this.Frame.Navigate(typeof(Pages.DetailFood), foodId);
        }
    }
}
