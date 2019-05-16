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
            _tempElements.Add(new Element("Lydvæggen", "Beskrivelse", "https://www.youtube.com/embed/q6EoRBvdVPQ?Autoplay=1", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["DAD"]);
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Blikfang", "Beskrivelse2", "https://www.youtube.com/embed/6bnanI9jXps?Autoplay=1", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Kim Larsen"]);

            _tempElements.Add(new Element("Jagten på den fede lyd", "Beskrivelse3", "https://www.youtube.com/embed/8YWl7tDGUPA?Autoplay=1", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Metallica"]);
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Metal"]);

            _tempElements.Add(new Element("Dance fever", "Beskrivelse4", "https://www.youtube.com/embed/SBeYzoQPbu8?Autoplay=1", AreaCatalog.Instance.Areas["Disco fever"]));
            _tempElements[3].AddTag(TagCatalog.Instance.Tags["Lys Show"]);

            _tempElements.Add(new Element("Pladespiller", "Beskrivelse5", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Skelv", "Beskrivelse6 ", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[5].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("LysShow", "Beskrivelse7", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[6].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Kassettebånd", "Beskrivelse8", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[7].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Telefon", "Beskrivelse9", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Den røde tråd", "Beskrivelse10", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Fandrenge og fanpiger", "Beskrivelse11", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["Rock"]);

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
