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
    public class ViewModel 
    {
        public static DataKatalog Catalog;

        private static int _key;

        public ViewModel()
        {
            Catalog = new DataKatalog();
            _key = 1;
        }
        
 

       public static int Key
       {
           get { return _key; }
           set { _key = value; }
       }
    
       public  string VideoLink
       {
           get {return Catalog.UdstillingsElementer[_key].VideoLink;}
       }

       public  string Name
       {
           get{ return Catalog.UdstillingsElementer[_key].Name;}
       }

       public  string Description
       {
           get { return Catalog.UdstillingsElementer[_key].Description; }
       }
     
    }
}

