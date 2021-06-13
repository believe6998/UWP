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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace assigment
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Pages.Home));
            lighthome.Background = oncolor.Background;
            lightEat.Background = mycolor.Background;
            lightDriverPayment.Background = mycolor.Background;
            lightCustomers.Background = mycolor.Background;
        }

        private void homebutton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Pages.Home));
            lighthome.Background = oncolor.Background;
            lightEat.Background = mycolor.Background;
            lightDriverPayment.Background = mycolor.Background;
            lightCustomers.Background = mycolor.Background;

        }

        private void eatbutton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Pages.Category));
            lighthome.Background = mycolor.Background;
            lightEat.Background = oncolor.Background;
            lightDriverPayment.Background = mycolor.Background;
            lightCustomers.Background = mycolor.Background;
        }

        private void paymentbutton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Pages.Payment));
            lighthome.Background = mycolor.Background;
            lightEat.Background = oncolor.Background;
            lightDriverPayment.Background = mycolor.Background;
            lightCustomers.Background = mycolor.Background;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }
    }
}