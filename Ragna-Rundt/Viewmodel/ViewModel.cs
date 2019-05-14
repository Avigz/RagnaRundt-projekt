using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.UI.ViewManagement;
using Ragna_Rundt.Model;

namespace Ragna_Rundt.Viewmodel
{
    public  class ViewModel : INotifyPropertyChanged
    {
     

      Dictionary<int,Element> Catalog = ElementCatalog.Instance.Elements;
    
      public static int StaticKey = 1;

    

       public int Key
       {
           get { return StaticKey; }
           set
           {
               StaticKey = value;
               OnPropertyChanged();
               OnPropertyChanged(nameof(Name));
               OnPropertyChanged(nameof(VideoLink));
               OnPropertyChanged(nameof(Description));
           }
       }
    
       public  string VideoLink
       {
           get {return Catalog[Key].videoURL;}
       }

       public  string Name
       {
           get{ return Catalog[Key].Name;}
       }

       public string Description
       {
           get { return Catalog[Key].description; }
       }

       public Dictionary<int, Element> CurrentList
       {
           get { return SearchList.Instance.CurrentList; }
       }

       public List<Tag> Filters
       {
           get { return SearchList.Instance.Filters; }
       }

       public List<Tag> AllFilters
       {
           get { return SearchList.Instance.AllFilters; }
       }

       public string SearchWord
       {
           get { return SearchList.Instance.SearchWord; }
       }


        public event PropertyChangedEventHandler PropertyChanged;

       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        { PropertyChanged?.Invoke(this,new  PropertyChangedEventArgs(propertyName));}

    }
}

