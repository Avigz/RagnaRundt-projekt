using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;

namespace Ragna_Rundt.Model
{
   public class ElementCatalog
    {
        private List<Element> _tempElements;
        private Dictionary<int, Element> _elements;
        private static ElementCatalog _instance;

        private ElementCatalog()
        {

            _tempElements = new List<Element>();

            //Lad der bliver lys:

            _tempElements.Add(new Element("Lysshow i 60'erne", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Lad der blive lys"]));
 
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Lysshow"]);
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Lysshow"]);

            _tempElements.Add(new Element("Levende Lys", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Lad der blive lys"]));
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Lysshow"]);
 
            _tempElements.Add(new Element("Teknologisk Lysshow", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Lad der blive lys"]));
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Teknologisk"]);
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Lysshow"]);
            
            
            _tempElements.Add(new Element("Lys effekter", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Lad der blive lys"]));
            _tempElements[3].AddTag(TagCatalog.Instance.Tags["Lysshow"]);

            //DanseFeber:

            _tempElements.Add(new Element("DiskoDasko", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["Dans"]);
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["Disko"]);
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["1960-1990"]);

            _tempElements.Add(new Element("Danse showet", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[5].AddTag(TagCatalog.Instance.Tags["Dans"]);
            _tempElements[5].AddTag(TagCatalog.Instance.Tags["Show"]);

            _tempElements.Add(new Element("Dansens Historie", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[6].AddTag(TagCatalog.Instance.Tags["Dans"]);
            _tempElements[6].AddTag(TagCatalog.Instance.Tags["Historie"]);
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["1960-1990"]);
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["1990-Nu"]);
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Før 1960"]);

            _tempElements.Add(new Element("Sygdoms dans", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[7].AddTag(TagCatalog.Instance.Tags["Dans"]);

            //Skælv:

            _tempElements.Add(new Element("Punkerne", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Punk"]);
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["1960-1990"]);

            _tempElements.Add(new Element("Skælvt i 90'erne", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Punk"]);
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["1990-Nu"]);
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);

            _tempElements.Add(new Element("90'erne og frem", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["1990-Nu"]);
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);

            _tempElements.Add(new Element("Ungdoms Skælvt", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[11].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);

            //Blikfang:

            _tempElements.Add(new Element("Hest på løbehjul", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[12].AddTag(TagCatalog.Instance.Tags["Løbehjulet"]);

            _tempElements.Add(new Element("Spejlet Time", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[13].AddTag(TagCatalog.Instance.Tags["Spejlestime"]);

            _tempElements.Add(new Element("Blikfangets indflydelse", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[14].AddTag(TagCatalog.Instance.Tags["Blikfangets indflydelse"]);

            _tempElements.Add(new Element("Blikfang gennem tiderne", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["Blikfang Historie"]);
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["1990-Nu"]);
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["1960-1990"]);
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["Før 1960"]);


            //Musikalske strømme:

            _tempElements.Add(new Element("Pop væggen", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
            _tempElements[16].AddTag(TagCatalog.Instance.Tags["Pop"]);
            
            _tempElements.Add(new Element("Rock væggen", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
           _tempElements[17].AddTag(TagCatalog.Instance.Tags["Rock"]);
            
            _tempElements.Add(new Element("Metal væggen", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Metal"]);

            _tempElements.Add(new Element("Den Klassike side", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Klassik"]);


            //Fandrenge, fanpiger:

            _tempElements.Add(new Element("Hvem råber højest", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Fans"]);
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Idoler"]);

            _tempElements.Add(new Element("Idoler", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Idoler"]);
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Fans"]);

            _tempElements.Add(new Element("Scene forhold", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[22].AddTag(TagCatalog.Instance.Tags["Scene"]);
            _tempElements[22].AddTag(TagCatalog.Instance.Tags["Scene forhold"]);

            _tempElements.Add(new Element("Fan art", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Fans"]);
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Fan art"]);
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Kunst"]);

            //Den røde tråd:

            _tempElements.Add(new Element("Musikkens røde tråd", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[24].AddTag(TagCatalog.Instance.Tags["Historisk"]);
            _tempElements[24].AddTag(TagCatalog.Instance.Tags["Rød tråd historie"]);

            _tempElements.Add(new Element("Den historiske røde tråd", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Historisk"]);
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Rød tråd historie"]);

            _tempElements.Add(new Element("Trendens påvirkning", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Det der Trender"]);
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Trendens påvirkning"]);
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Indflydelse"]);

            _tempElements.Add(new Element("Optur", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[27].AddTag(TagCatalog.Instance.Tags["Optur"]);
         
            //Elektrisk Intimitet:

            _tempElements.Add(new Element("Telefonens udvikling", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Elektrisk intimitet"]));
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Telefonens udvikling"]);
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Telefon"]);
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Udvikling"]);
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Forandring"]);

            _tempElements.Add(new Element("Mediernes indflydelse", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Elektrisk intimitet"]));
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Mediernes indflydelse"]);
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Medie"]);
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Indflydelse"]);

            //Rotation:

            _tempElements.Add(new Element("Pladespiller", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[30].AddTag(TagCatalog.Instance.Tags["Pladespiller"]);
            _tempElements[30].AddTag(TagCatalog.Instance.Tags["Plade"]);

            _tempElements.Add(new Element("Spil", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[31].AddTag(TagCatalog.Instance.Tags["Spil"]);
            _tempElements[31].AddTag(TagCatalog.Instance.Tags["Sjov"]);

            _tempElements.Add(new Element("Rotationens påvirkning", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[32].AddTag(TagCatalog.Instance.Tags["Rotationens påvirkning"]);
            _tempElements[32].AddTag(TagCatalog.Instance.Tags["Påvirkning"]);

            _tempElements.Add(new Element("Pladespiller til Ipod", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[33].AddTag(TagCatalog.Instance.Tags["Ipod"]);
            _tempElements[33].AddTag(TagCatalog.Instance.Tags["Pladespiller"]);
            _tempElements[33].AddTag(TagCatalog.Instance.Tags["Udvikling"]);

            //Jagten på den fede lyd:

            _tempElements.Add(new Element("Guitar solo", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[34].AddTag(TagCatalog.Instance.Tags["Lyd"]);
            _tempElements[34].AddTag(TagCatalog.Instance.Tags["Instrumenter"]);

            _tempElements.Add(new Element("Instrumenter", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[35].AddTag(TagCatalog.Instance.Tags["Instrumenter"]);
            _tempElements[35].AddTag(TagCatalog.Instance.Tags["Lyd"]);

            _tempElements.Add(new Element("Stop funk and run", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[36].AddTag(TagCatalog.Instance.Tags["Funk"]);
            _tempElements[36].AddTag(TagCatalog.Instance.Tags["Lyd"]);

            _tempElements.Add(new Element("Medie afstemning", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[37].AddTag(TagCatalog.Instance.Tags["Medie afstemning"]);
            _tempElements[37].AddTag(TagCatalog.Instance.Tags["Medie"]);
         
       
        
            //Demoteket:

            _tempElements.Add(new Element("Kassettebånd", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Demoteket"]));
            _tempElements[38].AddTag(TagCatalog.Instance.Tags["Kassettebånd"]);

            _tempElements.Add(new Element("COmegalulD", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Demoteket"])); // ?? mangler noget til denne eller slettes?
            //_tempElements[39].AddTag(TagCatalog.Instance.Tags["Demoteket"]); ???

            _tempElements.Add(new Element("Doc Johnson", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Demoteket"]));
            _tempElements[40].AddTag(TagCatalog.Instance.Tags["Doc Johnson"]);

            _elements = new Dictionary<int, Element>();

            foreach (Element element in _tempElements)
            {
                _elements.Add(element.Id, element);
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
