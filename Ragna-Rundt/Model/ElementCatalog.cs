using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
    class ElementCatalog
    {
        private List<Element> _tempElements;
        private Dictionary<int, Element> _elements;
        private TagCatalog lol;
        private static ElementCatalog _instance;

        private ElementCatalog()
        {
            
            _tempElements = new List<Element>();
            _tempElements.Add(new Element("DAD Bass", "Beskrivelse", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["DAD"]);
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Kim Larsens sko", "Beskrivelse2", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Kim Larsen"]);

            _tempElements.Add(new Element("Lars Ulrichs trommesæt", "Beskrivelse3", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Metallica"]);
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Metal"]);

            _tempElements.Add(new Element("Important Disco stuff", "Beskrivelse4", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Disco fever"]));
            _tempElements[3].AddTag(TagCatalog.Instance.Tags["Lys Show"]);

            _tempElements.Add(new Element("Pladespiller", "Beskrivelse5", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _elements = new Dictionary<int, Element>();
            foreach (Element element in _tempElements)
            {
                _elements.Add(element.Id,element);
            }
        }
        public static ElementCatalog Instance
        {
            get
            {
                if (_instance == null) _instance = new ElementCatalog();
                return _instance;
            }
        }
        public Dictionary<int, Element> Elements
        {
            get { return _elements; }
        }
    }
}
