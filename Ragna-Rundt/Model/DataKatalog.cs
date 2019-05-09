using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace Ragna_Rundt.Model

{
    public class DataKatalog
    {
        private  Dictionary<int,UdstillingsElement> _udstillingsElementer = new Dictionary<int, UdstillingsElement>();

        public DataKatalog()
        {
            UdstillingsElement a1 = new UdstillingsElement("Spejle", "https://www.youtube.com/embed/MvjQTA81MhY", "Spejl Rummet");
            UdstillingsElement a2 = new UdstillingsElement("Lys", "https://www.youtube.com/embed/s9jOm4Lbj-U?autoplay=1", "Lys Show");

            _udstillingsElementer.Add(1,a1);
            _udstillingsElementer.Add(2,a2);
        }

        public  Dictionary<int, UdstillingsElement> UdstillingsElementer
        {
            get { return _udstillingsElementer; }
            set { _udstillingsElementer = UdstillingsElementer; }
        }

        public  void Add(int key, UdstillingsElement Element)
        {
            _udstillingsElementer.Add(key,Element);
           
        }

        public  string VideoLink(int key)
        {
            return UdstillingsElementer[key].VideoLink;
        }

        public  string Name(int key)
        {
            return UdstillingsElementer[key].Name;
        }

        public  string Description(int key)
        {
            return UdstillingsElementer[key].Description;
        }
    }
}
