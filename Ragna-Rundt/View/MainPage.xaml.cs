using System;

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



        }

    }



}