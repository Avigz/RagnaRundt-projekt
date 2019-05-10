using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Windows.ApplicationModel.AppExtensions;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Editing;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Ragna_Rundt.Model;
using Ragna_Rundt.Viewmodel;


namespace Ragna_Rundt.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Udstillingstemplate : Page
    {
        ViewModel viewModel = new ViewModel();
        
        public Udstillingstemplate()
        {
            
            this.InitializeComponent();
            DataContext = viewModel;
            VideoLink.NavigateToString($"<iframe height=\"768\" width=\"1024\" src=" + $"{ElementCatalog.Instance.Elements[(viewModel.Key)].videoURL}" + "frameborder=\"0\" allow=\"accelerometer; encrypted-media; gyroscope; picture-in-picture\"></iframe>");

           

        }

        //public void ClickButton(object sender, RoutedEventArgs e)
        //{
        //    VideoLink.NavigateToString($"<iframe height=\"768\" width=\"1024\" src=" + $"{viewModel.Catalog.VideoLink(viewModel.Key)}" + "frameborder=\"0\" allow=\"accelerometer; encrypted-media; gyroscope; picture-in-picture\"></iframe>");
        //}

        private void Slider_OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            VideoLink.NavigateToString($"<iframe height=\"768\" width=\"1024\" src=" + $"{ElementCatalog.Instance.Elements[(viewModel.Key)].videoURL}" + "frameborder=\"0\" allow=\"accelerometer; encrypted-media; gyroscope; picture-in-picture\"></iframe>");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SplitviewMenu.IsPaneOpen == false)
            {
                SplitviewMenu.IsPaneOpen = true;
            }
            else if (SplitviewMenu.IsPaneOpen == true)
            {
                SplitviewMenu.IsPaneOpen = false;
            }
        }

        private void Kort_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Søg_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Søgeside));
        }

        private void Udstilling_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
