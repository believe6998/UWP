﻿#pragma checksum "C:\Users\DELL\Desktop\UWP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F947C032FE38FF3DC1B5C244C39081F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace assigment
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 17
                {
                    this.mycolor = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // MainPage.xaml line 118
                {
                    this.oncolor = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // MainPage.xaml line 168
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 5: // MainPage.xaml line 29
                {
                    this.homebutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.homebutton).Click += this.homebutton_Click;
                }
                break;
            case 6: // MainPage.xaml line 42
                {
                    this.eatbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.eatbutton).Click += this.eatbutton_Click;
                }
                break;
            case 7: // MainPage.xaml line 86
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.paymentbutton_Click;
                }
                break;
            case 8: // MainPage.xaml line 92
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element8 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element8).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 9: // MainPage.xaml line 19
                {
                    this.lighthome = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10: // MainPage.xaml line 20
                {
                    this.lightEat = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11: // MainPage.xaml line 21
                {
                    this.lightCollection = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 12: // MainPage.xaml line 22
                {
                    this.lightDelivery = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13: // MainPage.xaml line 23
                {
                    this.lightTakeAway = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14: // MainPage.xaml line 24
                {
                    this.lightDriverPayment = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 15: // MainPage.xaml line 25
                {
                    this.lightCustomers = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
