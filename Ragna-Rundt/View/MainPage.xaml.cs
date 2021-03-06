﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Ragna_Rundt.View;
using Ragna_Rundt.Viewmodel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ragna_Rundt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
           
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
            
        }

        private void Søg_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Søgeside));
        }

        private void Udstilling_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Rundvisnings_Button_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RundvisningsSide));
        }

        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        //Interaktiv kort funktionalitet

        private void Blikfang_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 2;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Hjerte_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 11;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Lydvaeg_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 1;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Cirkler_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 6;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Lysshow_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 7;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Verden_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 4;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Kassettebaand_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 8;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Telefon_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 9;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Mikrofon_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 3;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void Pladespiller_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 5;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        private void RagnarockBygning_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.StaticKey = 10;
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        //private void NavView_Navigate(NavigationViewItem item)
        //{
        //    switch (item.Tag)
        //    {
        //        case "Søg":
        //            this.Frame.Navigate(typeof(Søgeside),null);
        //            break;

        //        case "Udstilling":
        //            this.Frame.Navigate(typeof(Udstillingstemplate));
        //            break;
        //        case "Kort":
        //            this.Frame.Navigate(typeof(MainPage),null);
        //            break;
        //    }
        //}
    }

}
