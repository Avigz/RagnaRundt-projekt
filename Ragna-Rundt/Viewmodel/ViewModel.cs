using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;
using Windows.UI.ViewManagement;
using Ragna_Rundt.Model;

namespace Ragna_Rundt.Viewmodel
{
    public class ViewModel
    {

        public string VideoLink(int key)
        {
            return DataKatalog.UdstillingsElementer[key].VideoLink;
        }

        public string Name(int key)
        {
            return DataKatalog.UdstillingsElementer[key].Name;
        }

        public string Description(int key)
        {
            return DataKatalog.UdstillingsElementer[key].Description;
        }

    

    }
}

