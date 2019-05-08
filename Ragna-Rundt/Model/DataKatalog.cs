using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace Ragna_Rundt.Model

{
    public static class DataKatalog
    {
        private static Dictionary<int,UdstillingsElement> _udstillingsElementer = new Dictionary<int, UdstillingsElement>();

       static DataKatalog()
        {
            UdstillingsElement a1 = new UdstillingsElement("Spejle", "https://www.youtube.com/embed/MvjQTA81MhY", "SpejRummet");
            UdstillingsElement a2 = new UdstillingsElement("Lys", "https://youtube.com/embed/MvjQTA81MhY", "Lys Show");

            DataKatalog.Add(1,a1);
            DataKatalog.Add(2,a2);
        }

        public static Dictionary<int, UdstillingsElement> UdstillingsElementer
        {
            get { return _udstillingsElementer; }
            set { _udstillingsElementer = UdstillingsElementer; }
        }

        public static void Add(int key, UdstillingsElement Element)
        {
            _udstillingsElementer.Add(key,Element);
           
        }
        
        
    }
}
