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
using assigment.Services;
using assigment.Models;
using assigment.Dao.Impl;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace assigment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailFood : Page
    {
        Nullable<int> foodId;
        static FoodDetail food;
        public DetailFood()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            foodId = e.Parameter as Nullable<int>;
            System.Diagnostics.Debug.WriteLine("foodId in detail page : " + foodId);
            if (foodId != null) {
              getFoodDetail(foodId.Value);
            }
        }

        public async void getFoodDetail(int id)
        {
            List<Food> lsFoods = new List<Food>();
            DetailService service = new DetailService();
            food = await service.getFoodDetail(id);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            food.data.price = double.Parse(food.data.price).ToString("#,###", cul.NumberFormat) + " VND";
            lsFoods.Add(food.data);
            FoodDetailItem.ItemsSource = lsFoods;

        }
    }
}
