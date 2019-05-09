using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;
using Windows.UI.ViewManagement;
using Ragna_Rundt.Model;

namespace Ragna_Rundt.Viewmodel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public DataKatalog Catalog = new DataKatalog();

        private int _key = 1;
      
 

       public int Key
       {
           get { return _key; }
           set
           {
               _key = value;
               OnPropertyChanged();
               OnPropertyChanged(nameof(Name));
               OnPropertyChanged(nameof(VideoLink));
               OnPropertyChanged(nameof(Description));

           }
       }
    
       public  string VideoLink
       {
           get {return Catalog.UdstillingsElementer[Key].VideoLink;}
       }

       public  string Name
       {
           get{ return Catalog.UdstillingsElementer[Key].Name;}
       }

       public string Description
       {
           get { return Catalog.UdstillingsElementer[Key].Description; }
       }

       public event PropertyChangedEventHandler PropertyChanged;

       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        { PropertyChanged?.Invoke(this,new  PropertyChangedEventArgs(propertyName));}

    }
}

