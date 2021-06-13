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
using assigment.Models;
using assigment.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace assigment.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Category : Page
    {
        public Category()
        {
            this.InitializeComponent();
            getcategory();
        }

        public async void getcategory()
        {
            var lsCategory = new List<CategoryData>();
            var service = new CategoryService();
            for (var id = 1; id < 6; id++)
            {
                var catagoryRootdata = await service.getCategoryPage(id);
                if (catagoryRootdata != null)
                {
                    lsCategory.Add(catagoryRootdata.data);
                }
            }
            MNItems.ItemsSource = lsCategory;


        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;
            // Title.Text = msg;
        }


        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var foods = ((ListViewItem)sender).Tag;
            this.Frame.Navigate(typeof(Pages.Foods), foods);
        }
    }

}
