using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
    public class TagCatalog
    {
        private Dictionary<string, Tag> _tags;
        private static TagCatalog _instance;
        private TagCatalog()
        {
            _tags = new Dictionary<string, Tag>();
            _tags.Add("Doc Johnson", new Tag("Doc Johnson"));
            _tags.Add("Johnson", new Tag("Johnson"));
            _tags.Add("Doc", new Tag("Doc"));
            _tags.Add("Demoteket", new Tag("Demoteket"));
            _tags.Add("Omegalul", new Tag("Metallica"));
            _tags.Add("CD", new Tag("Rock"));
            _tags.Add("COmegalulD", new Tag("Pop"));
            _tags.Add("Kassettebånd", new Tag("Kassettebånd"));
            _tags.Add("Medier", new Tag("Medier"));
            _tags.Add("Medie", new Tag("Medie"));
            _tags.Add("Medie afstemning", new Tag("Medie afstemning"));
            _tags.Add("Jagten på den fede lyd", new Tag("Jagten på den fede lyd"));
            _tags.Add("Instrument", new Tag("Instrument"));
            _tags.Add("Instrumenter", new Tag("Instrumenter"));
            _tags.Add("Funk", new Tag("Funk"));
            _tags.Add("Funk and run", new Tag("Funk and run"));
            _tags.Add("Lyd", new Tag("Lyd"));
            _tags.Add("Guitar", new Tag("Guitar"));
            _tags.Add("Guitar solo", new Tag("Guitar solo"));
            _tags.Add("Udvikling", new Tag("Udvikling"));
            _tags.Add("Pladespiller", new Tag("Pladespiller"));
            _tags.Add("Ipod", new Tag("Ipod"));
            _tags.Add("Rotation", new Tag("Rotation"));
            _tags.Add("Påvirkning", new Tag("Påvirkning"));
            _tags.Add("Rotationens påvirkning", new Tag("Rotationens påvirkning"));
            _tags.Add("Sjov", new Tag("Sjov"));
            _tags.Add("Game", new Tag("Game"));
            _tags.Add("Plade", new Tag("Plade"));
            _tags.Add("Pladespiller", new Tag("Pladespiller"));
            _tags.Add("Telefonens påvirkning", new Tag("Telefonens påvirkning"));
            _tags.Add("Elektrisk Intimitet", new Tag("Elektrisk Intimitet"));
            _tags.Add("Forandring", new Tag("Forandring"));
            _tags.Add("Udvikling", new Tag("Udvikling"));
            _tags.Add("Telefon", new Tag("Telefon"));
            _tags.Add("Fest og farver", new Tag("Fest og farver"));
            _tags.Add("God dag", new Tag("God dag"));
            _tags.Add("Optur", new Tag("Optur"));
            _tags.Add("Feelsgoodman", new Tag("Feelsgoodman"));
            _tags.Add("Den røde tråd", new Tag("Den røde tråd"));
            _tags.Add("Trendens påvirkning", new Tag("Trendens påvirkning"));
            _tags.Add("Trend", new Tag("Trend"));
            _tags.Add("Tråd", new Tag("Tråd"));
            _tags.Add("Rød", new Tag("Rød"));
            _tags.Add("Rød tråd historie", new Tag("Rød tråd historie"));
            _tags.Add("Historisk", new Tag("Historisk"));
            _tags.Add("Kunst", new Tag("Kunst"));
            _tags.Add("Art", new Tag("Art"));
            _tags.Add("Fan art", new Tag("Fan art"));
            _tags.Add("Fandrenge, Fanpiger", new Tag("Fandrenge, Fanpiger"));
            _tags.Add("Scene forhold", new Tag("Scene forhold"));
            _tags.Add("Scene", new Tag("Scene"));
            _tags.Add("Idoler", new Tag("Idoler"));
            _tags.Add("Idol", new Tag("Idol"));
            _tags.Add("Fanpiger", new Tag("Fans"));
            _tags.Add("Fandrenge", new Tag("Fans"));
            _tags.Add("Igor Stravinskij", new Tag("Igor Stravinskij"));
            _tags.Add("Johann Sebastian Bach", new Tag("Johann Sebastian Bach"));
            _tags.Add("Ludwig van Beethoven", new Tag("Ludwig van Beethoven"));
            _tags.Add("Wolfgang Amadeus Mozart", new Tag("Wolfgang Amadeus Mozart"));
            _tags.Add("Klassik", new Tag("Klassik"));
            _tags.Add("Musik", new Tag("Musik"));
            _tags.Add("Musikalske strømme", new Tag("Musikalske strømme"));
            _tags.Add("Metallica", new Tag("Metallica"));
            _tags.Add("Fiends", new Tag("Fiends"));
            _tags.Add("Gojira", new Tag("Gojira"));
            _tags.Add("Jason Richard", new Tag("Jason Richard"));
            _tags.Add("Avenged Sevenfold", new Tag("Avenged Sevenfold"));
            _tags.Add("Adept", new Tag("Adept"));
            _tags.Add("Metal", new Tag("Metal"));
            _tags.Add("Guns & Roses", new Tag("Guns & Roses"));
            _tags.Add("D.A.D", new Tag("D.A.D"));
            _tags.Add("D-A-D", new Tag("D-A-D"));
            _tags.Add("Rock", new Tag("Rock"));
            _tags.Add("Væg", new Tag("Væg"));
            _tags.Add("Taylor Swift", new Tag("Taylor Swift"));
            _tags.Add("Pop", new Tag("Pop"));
            _tags.Add("Gennem tiderne", new Tag("Gennem tiderne"));
            _tags.Add("Historie", new Tag("Historie"));
            _tags.Add("Blikfang Historie", new Tag("Blikfang Historie"));
            _tags.Add("Blikfang", new Tag("Blikfang"));
            _tags.Add("Blikfangets indflydelse", new Tag("Blikfangets indflydelse"));
            _tags.Add("Time", new Tag("Time"));
            _tags.Add("Spej", new Tag("Spej"));
            _tags.Add("Løbehjul", new Tag("Løbehjul"));
            _tags.Add("Hest", new Tag("Hest"));
            _tags.Add("Ungdoms kultur", new Tag("Ungdoms kultur"));
            _tags.Add("Ungdom", new Tag("Ungdom"));
            _tags.Add("Skævle", new Tag("Skævle"));
            _tags.Add("2010'erne", new Tag("2010'erne"));
            _tags.Add("2000'erne", new Tag("2000'erne"));
            _tags.Add("90'erne", new Tag("90'erne"));
            _tags.Add("Punk", new Tag("Punk"));
            _tags.Add("Punker", new Tag("Punker"));
            _tags.Add("Dans", new Tag("Dans"));
            _tags.Add("DanseFeber", new Tag("DanseFeber"));
            _tags.Add("Show", new Tag("Show"));
            _tags.Add("Disko", new Tag("Disko"));
            _tags.Add("Lad der blive lys", new Tag("Lad der blive lys"));
            _tags.Add("Lysshow", new Tag("Lysshow"));
            _tags.Add("Lys", new Tag("Lys"));
            _tags.Add("Teknologisk", new Tag("Teknologisk"));
            _tags.Add("Levende Lys", new Tag("Levende Lys"));
        }
        public static TagCatalog Instance
        {
            get
            {
                if (_instance == null) _instance = new TagCatalog();
                return _instance;
            }
        }
        public Dictionary<string, Tag> Tags
        {
            get { return _tags; }
        }
    }
}
