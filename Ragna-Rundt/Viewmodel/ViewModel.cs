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
    public static class ViewModel 
    {
        public static DataKatalog Catalog = new DataKatalog();

        private static int _key = 1;
      
 

       public static int Key
       {
           get { return _key; }
           set { _key = value; }
       }
    
       public static string VideoLink
       {
           get {return Catalog.UdstillingsElementer[_key].VideoLink;}
       }

       public static string Name
       {
           get{ return Catalog.UdstillingsElementer[_key].Name;}
       }

       public static string Description
       {
           get { return Catalog.UdstillingsElementer[_key].Description; }
       }
     
    }
}

