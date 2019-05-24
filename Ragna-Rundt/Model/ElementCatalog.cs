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
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Lys"]);
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Lysshow"]);
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Lad der blive lys"]);

            _tempElements.Add(new Element("Levende Lys", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Lad der blive lys"]));
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Lys"]);
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Levende Lys"]);
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Lysshow"]);
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Lad der blive lys"]);

            _tempElements.Add(new Element("Teknologisk Lysshow", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Lad der blive lys"]));
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Lys"]);
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Teknologisk"]);
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Lysshow"]);
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Lad der blive lys"]);


            _tempElements.Add(new Element("Lys effekter", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Lad der blive lys"]));
            _tempElements[3].AddTag(TagCatalog.Instance.Tags["Lys"]);
            _tempElements[3].AddTag(TagCatalog.Instance.Tags["Lysshow"]);
            _tempElements[3].AddTag(TagCatalog.Instance.Tags["Lad der blive lys"]);

            //DanseFeber:

            _tempElements.Add(new Element("DiskoDasko", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["DanseFeber"]);
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["Dans"]);
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["Disko"]);

            _tempElements.Add(new Element("Danse showet", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[5].AddTag(TagCatalog.Instance.Tags["DanseFeber"]);
            _tempElements[5].AddTag(TagCatalog.Instance.Tags["Dans"]);
            _tempElements[5].AddTag(TagCatalog.Instance.Tags["Show"]);

            _tempElements.Add(new Element("Dansens Historie", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[6].AddTag(TagCatalog.Instance.Tags["DanseFeber"]);
            _tempElements[6].AddTag(TagCatalog.Instance.Tags["Dans"]);
            _tempElements[6].AddTag(TagCatalog.Instance.Tags["Historie"]);

            _tempElements.Add(new Element("Sygdoms dans", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Dansefeber"]));
            _tempElements[7].AddTag(TagCatalog.Instance.Tags["DanseFeber"]);
            _tempElements[7].AddTag(TagCatalog.Instance.Tags["Dans"]);

            //Skælv:

            _tempElements.Add(new Element("Punkerne", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Punk"]);
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Punker"]);
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Skælv"]);
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);

            _tempElements.Add(new Element("Skælvt i 90'erne", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Skælv"]);
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Punk"]);
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["90'erne"]);
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);

            _tempElements.Add(new Element("90'erne og frem", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["Skælv"]);
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["90'erne"]);
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["2000'erne"]);
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["2010'erne"]);
            _tempElements[10].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);

            _tempElements.Add(new Element("Ungdoms Skælvt", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Skælv"]));
            _tempElements[11].AddTag(TagCatalog.Instance.Tags["Skælv"]);
            _tempElements[11].AddTag(TagCatalog.Instance.Tags["Ungdom"]);
            _tempElements[11].AddTag(TagCatalog.Instance.Tags["Ungdoms kultur"]);

            //Blikfang:

            _tempElements.Add(new Element("Hest på løbehjul", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[12].AddTag(TagCatalog.Instance.Tags["Blikfang"]);
            _tempElements[12].AddTag(TagCatalog.Instance.Tags["Hest"]);
            _tempElements[12].AddTag(TagCatalog.Instance.Tags["Løbehjul"]);

            _tempElements.Add(new Element("Spejlet Time", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[13].AddTag(TagCatalog.Instance.Tags["Blikfang"]);
            _tempElements[13].AddTag(TagCatalog.Instance.Tags["Spej"]);
            _tempElements[13].AddTag(TagCatalog.Instance.Tags["Time"]);

            _tempElements.Add(new Element("Blikfangets indflydelse", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[14].AddTag(TagCatalog.Instance.Tags["Blikfang"]);
            _tempElements[14].AddTag(TagCatalog.Instance.Tags["Blikfangets indflydelse"]);

            _tempElements.Add(new Element("Blikfang gennem tiderne", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Blikfang"]));
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["Blikfang"]);
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["Blikfang Historie"]);
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["Historie"]);
            _tempElements[15].AddTag(TagCatalog.Instance.Tags["Gennem tiderne"]);

            //Musikalske strømme:

            _tempElements.Add(new Element("Pop væggen", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
            _tempElements[16].AddTag(TagCatalog.Instance.Tags["Musikalske strømme"]);
            _tempElements[16].AddTag(TagCatalog.Instance.Tags["Musik"]);
            _tempElements[16].AddTag(TagCatalog.Instance.Tags["Pop"]);
            _tempElements[16].AddTag(TagCatalog.Instance.Tags["Taylor Swift"]);
            _tempElements[16].AddTag(TagCatalog.Instance.Tags["Væg"]);

            _tempElements.Add(new Element("Rock væggen", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
            _tempElements[17].AddTag(TagCatalog.Instance.Tags["Musikalske strømme"]);
            _tempElements[17].AddTag(TagCatalog.Instance.Tags["Musik"]);
            _tempElements[17].AddTag(TagCatalog.Instance.Tags["Rock"]);
            _tempElements[17].AddTag(TagCatalog.Instance.Tags["D-A-D"]);
            _tempElements[17].AddTag(TagCatalog.Instance.Tags["D.A.D"]);
            _tempElements[17].AddTag(TagCatalog.Instance.Tags["Guns & Roses"]);

            _tempElements.Add(new Element("Metal væggen", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Musikalske strømme"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Musik"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Metal"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Adept"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Avenged Sevenfold"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Jason Richard"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Gojira"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Fiends"]);
            _tempElements[18].AddTag(TagCatalog.Instance.Tags["Metallica"]);

            _tempElements.Add(new Element("Den Klassike side", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Musikalske strømme"]));
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Musikalske strømme"]);
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Musik"]);
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Klassik"]);
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Wolfgang Amadeus Mozart"]);
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Ludwig van Beethoven"]);
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Johann Sebastian Bach"]);
            _tempElements[19].AddTag(TagCatalog.Instance.Tags["Igor Stravinskij"]);

            //Fandrenge, fanpiger:

            _tempElements.Add(new Element("Hvem råber højest", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Fandrenge, Fanpiger"]);
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Fandrenge"]);
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Fanpiger"]);
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Fan"]);
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Fans"]);
            _tempElements[20].AddTag(TagCatalog.Instance.Tags["Idol"]);

            _tempElements.Add(new Element("Idoler", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Fandrenge, Fanpiger"]);
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Fandrenge"]);
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Fanpiger"]);
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Idol"]);
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Idoler"]);
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Fan"]);
            _tempElements[21].AddTag(TagCatalog.Instance.Tags["Fans"]);

            _tempElements.Add(new Element("Scene forhold", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[22].AddTag(TagCatalog.Instance.Tags["Fandrenge, Fanpiger"]);
            _tempElements[22].AddTag(TagCatalog.Instance.Tags["Scene"]);
            _tempElements[22].AddTag(TagCatalog.Instance.Tags["Scene forhold"]);

            _tempElements.Add(new Element("Fan art", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Fandrenge og fanpiger"]));
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Fandrenge, Fanpiger"]);
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Fan"]);
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Fans"]);
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Fan art"]);
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Art"]);
            _tempElements[23].AddTag(TagCatalog.Instance.Tags["Kunst"]);

            //Den røde tråd:

            _tempElements.Add(new Element("Musikkens røde tråd", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[24].AddTag(TagCatalog.Instance.Tags["Den røde tråd"]);
            _tempElements[24].AddTag(TagCatalog.Instance.Tags["Rød"]);
            _tempElements[24].AddTag(TagCatalog.Instance.Tags["Tråd"]);


            _tempElements.Add(new Element("Den historiske røde tråd", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Den røde tråd"]);
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Rød"]);
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Tråd"]);
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Historie"]);
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Historisk"]);
            _tempElements[25].AddTag(TagCatalog.Instance.Tags["Rød tråd historie"]);

            _tempElements.Add(new Element("Trendens påvirkning", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Den røde tråd"]);
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Rød"]);
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Tråd"]);
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Trend"]);
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Trendens påvirkning"]);
            _tempElements[26].AddTag(TagCatalog.Instance.Tags["Indflydelse"]);

            _tempElements.Add(new Element("Optur", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Den røde tråd"]));
            _tempElements[27].AddTag(TagCatalog.Instance.Tags["Den røde tråd"]);
            _tempElements[27].AddTag(TagCatalog.Instance.Tags["Feelsgoodman"]);
            _tempElements[27].AddTag(TagCatalog.Instance.Tags["Optur"]);
            _tempElements[27].AddTag(TagCatalog.Instance.Tags["God dag"]);
            _tempElements[27].AddTag(TagCatalog.Instance.Tags["Fest og farver"]);

            //Elektrisk Intimitet:

            _tempElements.Add(new Element("Telefonens udvikling", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Elektrisk intimitet"]));
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Elektrisk Intimitet"]);
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Telefonens udvikling"]);
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Telefon"]);
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Udvikling"]);
            _tempElements[28].AddTag(TagCatalog.Instance.Tags["Forandring"]);

            _tempElements.Add(new Element("Mediernes indflydelse", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Elektrisk intimitet"]));
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Elektrisk Intimitet"]);
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Mediernes indflydelse"]);
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Medier"]);
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Medie"]);
            _tempElements[29].AddTag(TagCatalog.Instance.Tags["Indflydelse"]);

            //Rotation:

            _tempElements.Add(new Element("Pladespiller", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[30].AddTag(TagCatalog.Instance.Tags["Rotation"]);
            _tempElements[30].AddTag(TagCatalog.Instance.Tags["Pladespiller"]);
            _tempElements[30].AddTag(TagCatalog.Instance.Tags["Plade"]);

            _tempElements.Add(new Element("Spil", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[31].AddTag(TagCatalog.Instance.Tags["Rotation"]);
            _tempElements[31].AddTag(TagCatalog.Instance.Tags["Spil"]);
            _tempElements[31].AddTag(TagCatalog.Instance.Tags["Game"]);
            _tempElements[31].AddTag(TagCatalog.Instance.Tags["Sjov"]);

            _tempElements.Add(new Element("Rotationens påvirkning", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[32].AddTag(TagCatalog.Instance.Tags["Rotation"]);
            _tempElements[32].AddTag(TagCatalog.Instance.Tags["Rotationens påvirkning"]);
            _tempElements[32].AddTag(TagCatalog.Instance.Tags["Påvirkning"]);

            _tempElements.Add(new Element("Pladespiller til Ipod", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Rotation"]));
            _tempElements[33].AddTag(TagCatalog.Instance.Tags["Rotation"]);
            _tempElements[33].AddTag(TagCatalog.Instance.Tags["Ipod"]);
            _tempElements[33].AddTag(TagCatalog.Instance.Tags["Pladespiller"]);
            _tempElements[33].AddTag(TagCatalog.Instance.Tags["Udvikling"]);

            //Jagten på den fede lyd:

            _tempElements.Add(new Element("Guitar solo", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[34].AddTag(TagCatalog.Instance.Tags["Jagten på den fede lyd"]);
            _tempElements[34].AddTag(TagCatalog.Instance.Tags["Guitar"]);
            _tempElements[34].AddTag(TagCatalog.Instance.Tags["Lyd"]);
            _tempElements[34].AddTag(TagCatalog.Instance.Tags["Instrument"]);

            _tempElements.Add(new Element("Instrumenter", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[35].AddTag(TagCatalog.Instance.Tags["Jagten på den fede lyd"]);
            _tempElements[35].AddTag(TagCatalog.Instance.Tags["Instrumenter"]);
            _tempElements[35].AddTag(TagCatalog.Instance.Tags["Instrument"]);

            _tempElements.Add(new Element("Stop funk and run", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[36].AddTag(TagCatalog.Instance.Tags["Jagten på den fede lyd"]);
            _tempElements[36].AddTag(TagCatalog.Instance.Tags["Stop funk and run"]);
            _tempElements[36].AddTag(TagCatalog.Instance.Tags["Funk"]);
            _tempElements[36].AddTag(TagCatalog.Instance.Tags["Funk and run"]);

            _tempElements.Add(new Element("Medie afstemning", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Jagten på den fede lyd"]));
            _tempElements[37].AddTag(TagCatalog.Instance.Tags["Jagten på den fede lyd"]);
            _tempElements[37].AddTag(TagCatalog.Instance.Tags["Medie afstemning"]);
            _tempElements[37].AddTag(TagCatalog.Instance.Tags["Medie"]);
            _tempElements[37].AddTag(TagCatalog.Instance.Tags["Medier"]);
       
        
            //Demoteket:

            _tempElements.Add(new Element("Kassettebånd", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Demoteket"]));
            _tempElements[38].AddTag(TagCatalog.Instance.Tags["Demoteket"]);
            _tempElements[38].AddTag(TagCatalog.Instance.Tags["Kassettebånd"]);

            _tempElements.Add(new Element("COmegalulD", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Demoteket"]));
            _tempElements[39].AddTag(TagCatalog.Instance.Tags["Demoteket"]);

            _tempElements.Add(new Element("Doc Johnson", "PlaceHolder text", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Demoteket"]));
            _tempElements[40].AddTag(TagCatalog.Instance.Tags["Demoteket"]);
            _tempElements[40].AddTag(TagCatalog.Instance.Tags["Doc"]);
            _tempElements[40].AddTag(TagCatalog.Instance.Tags["Johnson"]);
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
