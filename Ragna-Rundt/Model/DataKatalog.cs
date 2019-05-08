using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
    public class DataKatalog
    {
        private Dictionary<int,UdstillingsElement> _udstillingsElementer;

        public DataKatalog()
        {

        }

        public Dictionary<int, UdstillingsElement> UdstillingsElementer
        {
            get { return _udstillingsElementer; }
            set { _udstillingsElementer = UdstillingsElementer; }
        }

    }
}
