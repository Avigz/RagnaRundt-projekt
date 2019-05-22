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
using Ragna_Rundt.Model;
using Ragna_Rundt.Viewmodel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ragna_Rundt.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class Søgeside : Page
    {
     
        //public int ElementKey;
        ViewModel viewModel = new ViewModel();

        public Søgeside()
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
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Søg_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Rundvisnings_Button_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RundvisningsSide));
        }

        private void Udstilling_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

       // Listview knapfunktioner til navigering til underside m. indhold der matcher titlen på den aktiverede knap.
       // Disse fungerer ved at have binded elementets Key til *Tag* parameteren i Button elementet.
       // Tag elementet returnere et objekt med vores Key i, hvilken vi ekstrahere ved at konvertere objectet til en int. 
       // For at videregive den ønskede indholdsstyringsKey til ViewModellen, lægger vi den over i den statiske Key variable StaticKey.
       //efter dette kalder vi frame.Navigate og videredirigere til udstillingstemplaten, hvilkens indhold er opdateret efter StaticKey.

        public void ListButton_OnClick(object sender, RoutedEventArgs e)
        {
            var Key = ((Button)sender).Tag;
            

            ViewModel.StaticKey = Convert.ToInt16(Key);
          
            this.Frame.Navigate(typeof(Udstillingstemplate));
        }

        /*
        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Only get results when it was a user typing, 
            // otherwise assume the value got filled in by TextMemberPath 
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                //Set the ItemsSource to be your filtered dataset
                sender.ItemsSource = viewModel.searchList.Filters;
            }
        }


        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
            sender.Text = viewModel.searchList.SearchWord;
        }


        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
               //viewModel.searchList.AddFilter();
            }
            else
            {
                // Use args.QueryText to determine what to do.
                viewModel.searchList.SearchWord = args.QueryText;
                viewModel.searchList.Search();
                viewModel.searchList.Update();
            }
        }*/

        
    }
}
