using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rag.Domain
{
    class AreaCatalog
    {
        private Dictionary<string, Area> _areas;
        private static AreaCatalog _instance;

        private AreaCatalog()
        {
            _areas = new Dictionary<string, Area>();
            _areas.Add("Pladespilleren",  new Area("Pladespillerrummet", "beskrivelse", 1, 1));
            _areas.Add("Disco fever", new Area("Disco fever", "beskrivelse2", 2, 2));
            _areas.Add("Væg of doom", new Area("Væg of doom", "beskrivelse3", 3, 3));
        }
        public static AreaCatalog Instance
        {
            get
            {
                if (_instance == null) _instance = new AreaCatalog();
                return _instance;
            }
        }

        public Dictionary<string, Area> Areas
        {
            get { return _areas; }
        }
    }
}
