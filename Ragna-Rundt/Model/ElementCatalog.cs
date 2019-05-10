using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rag.Domain
{
    class ElementCatalog
    {
        private List<Element> _elements;
        private TagCatalog lol;
        private static ElementCatalog _instance;

        private ElementCatalog()
        {
            
            _elements = new List<Element>();
            _elements.Add(new Element("DAD Bass", "Beskrivelse", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Væg of doom"]));
            _elements[0].AddTag(TagCatalog.Instance.Tags["DAD"]);
            _elements[0].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _elements.Add(new Element("Kim Larsens sko", "Beskrivelse2", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Væg of doom"]));
            _elements[1].AddTag(TagCatalog.Instance.Tags["Kim Larsen"]);

            _elements.Add(new Element("Lars Ulrichs trommesæt", "Beskrivelse3", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Væg of doom"]));
            _elements[2].AddTag(TagCatalog.Instance.Tags["Metallica"]);
            _elements[2].AddTag(TagCatalog.Instance.Tags["Metal"]);

            _elements.Add(new Element("Important Disco stuff", "Beskrivelse4", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Disco fever"]));
            _elements[3].AddTag(TagCatalog.Instance.Tags["Lys Show"]);

            _elements.Add(new Element("Pladespiller", "Beskrivelse5", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _elements[4].AddTag(TagCatalog.Instance.Tags["Rock"]);

        }
        public static ElementCatalog Instance
        {
            get
            {
                if (_instance == null) _instance = new ElementCatalog();
                return _instance;
            }
        }
        public List<Element> Elements
        {
            get { return _elements; }
        }
    }
}
