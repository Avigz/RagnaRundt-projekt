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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ragna_Rundt.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BurgerMenu1 : Page
    {
        public BurgerMenu1()
        {
            this.InitializeComponent();
        }

        private void NavigationView_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (NavigationViewItemBase item in NavigationView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "Kort_Side")
                {
                    NavigationView.SelectedItem = item;
                    break;
                }

                if (item is NavigationViewItem && item.Tag.ToString() == "Søge_Side")
                {
                    this.Frame.Navigate(typeof(Søgeside));
                    break;
                }

                if (item is NavigationViewItem && item.Tag.ToString() == "Udstillings_Side")
                {
                    this.Frame.Navigate(typeof(Udstillingstemplate));
                    break;
                }

            }
        }
    }
}
//            this.Frame.Navigate(typeof(MainPage));
//        }
//        }

//        private void NavigationView_OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
//        {
//            throw new NotImplementedException();
//        }

//        private void NavigationView_OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
//    {
//    TextBlock ItemContent = args.InvokedItem as TextBlock;
//        if (ItemContent != null)
//    {
//            switch (ItemContent.Tag)
//{
//case "Nav_Home":
//this.Frame.Navigate(typeof(HomePage));
//break;

//case "Nav_Shop":
//this.Frame.Navigate(typeof(ShopPage));
//break;

//case "Nav_ShopCart":
//this.Frame.Navigate(typeof(CartPage));
//break;

//    }
//    }

