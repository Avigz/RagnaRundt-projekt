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

      public SearchList searchList = SearchList.Instance;

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

       private bool _tilbageIsVisible = true;
       private bool _næsteIsVisible = true;
       private bool _afslutTourIsVisible = true;

       public bool TilbageIsVisible
       {
           get { return _tilbageIsVisible; }
           set
           {
               _tilbageIsVisible = value;
               OnPropertyChanged(nameof(TilbageIsVisible));
           }
       }

       public bool NæsteIsVisible
       {
           get { return _næsteIsVisible; }
           set
           {
               _næsteIsVisible = value;
               OnPropertyChanged(nameof(NæsteIsVisible));
           }
       }

       public bool AfslutTourIsVisible
       {
           get { return _afslutTourIsVisible; }
           set
           {
               _afslutTourIsVisible = value;
               OnPropertyChanged(nameof(AfslutTourIsVisible));
           }
       }




        public event PropertyChangedEventHandler PropertyChanged;

       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        { PropertyChanged?.Invoke(this,new  PropertyChangedEventArgs(propertyName));}

    }
}

