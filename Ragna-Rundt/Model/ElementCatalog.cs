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

            _tempElements.Add(new Element("Lydvæggen", "Readymade kale chips portland kogi, jean shorts jianbing actually post-ironic knausgaard copper mug vexillologist gastropub distillery raw denim. Typewriter ethical migas viral portland. Venmo kickstarter XOXO, shaman 90's swag normcore jianbing glossier retro shoreditch banjo. Cray ugh microdosing, +1 pickled tumblr cornhole asymmetrical franzen raclette. Aesthetic taiyaki hell of man braid fashion axe pour-over. Art party blue bottle subway tile meggings blog, thundercats prism craft beer +1 jean shorts brunch put a bird on it. Taiyaki cardigan narwhal, lomo kogi PBR&B swag tattooed shoreditch pabst activated charcoal.", "https://www.youtube.com/embed/q6EoRBvdVPQ?Autoplay=1", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["DAD"]);
            _tempElements[0].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Blikfang", "Fingerstache kickstarter meh wayfarers microdosing woke beard flannel banh mi butcher. Kickstarter raw denim narwhal readymade williamsburg brunch pug vape seitan waistcoat. La croix kinfolk marfa direct trade. Bushwick tattooed distillery chambray bicycle rights wayfarers tousled.", "https://www.youtube.com/embed/6bnanI9jXps?Autoplay=1", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[1].AddTag(TagCatalog.Instance.Tags["Kim Larsen"]);

            _tempElements.Add(new Element("Jagten på den fede lyd", "Tousled DIY lomo palo santo. Brunch drinking vinegar kickstarter raw denim hella yr af kombucha heirloom church-key chia. Dreamcatcher shabby chic venmo la croix, butcher master cleanse coloring book mlkshk post-ironic synth cronut. Irony DIY lo-fi butcher man braid cornhole gluten-free PBR&B pickled intelligentsia jianbing heirloom bitters. Brooklyn beard tumblr 90's taiyaki, ", "https://www.youtube.com/embed/8YWl7tDGUPA?Autoplay=1", AreaCatalog.Instance.Areas["Væg of doom"]));
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Metallica"]);
            _tempElements[2].AddTag(TagCatalog.Instance.Tags["Metal"]);

            _tempElements.Add(new Element("Dance fever", "narwhal selfies live-edge. Readymade polaroid vaporware cred wolf aesthetic pok pok chartreuse edison bulb echo park cray 3 wolf moon YOLO. Cray vice franzen, fashion axe squid drinking vinegar gentrify bitters dreamcatcher hell of pickled man bun asymmetrical.", "https://www.youtube.com/embed/SBeYzoQPbu8?Autoplay=1", AreaCatalog.Instance.Areas["Disco fever"]));
            _tempElements[3].AddTag(TagCatalog.Instance.Tags["Lys Show"]);

            _tempElements.Add(new Element("Pladespiller", "Direct trade bitters meditation tofu meggings pug celiac lyft kitsch adaptogen mlkshk venmo mixtape migas synth. Dreamcatcher glossier umami slow-carb prism austin flexitarian hella mixtape messenger bag. PBR&B waistcoat wolf yuccie pop-up gastropub. Fam squid hoodie, enamel pin drinking vinegar man braid food truck synth unicorn yr meh flannel tumeric. ", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[4].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Skelv", "Humblebrag cold-pressed marfa sriracha everyday carry flexitarian quinoa retro. Snackwave offal ethical trust fund normcore distillery irony. Disrupt pork belly retro ugh VHS art party meggings glossier distillery roof party stumptown edison bulb.", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[5].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("LysShow", "Bicycle rights master cleanse franzen meh beard kickstarter truffaut craft beer put a bird on it thundercats. Swag literally tumeric green juice gentrify pinterest. Yr keytar next level, hoodie before they sold out trust fund crucifix VHS tattooed pork belly semiotics pickled leggings master cleanse. Truffaut lomo polaroid drinking vinegar, taxidermy irony wayfarers brooklyn wolf waistcoat.", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[6].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Kassettebånd", "Sartorial la croix ethical tofu marfa roof party heirloom mlkshk salvia photo booth. Live-edge messenger bag typewriter narwhal. Fanny pack hexagon cronut messenger bag etsy cred. Affogato selvage microdosing flannel, cold-pressed kinfolk four dollar toast kale chips af butcher salvia meditation banh mi kogi. Marfa umami post-ironic brooklyn, before they sold out jianbing pop-up tofu vaporware farm-to-table sartorial biodiesel mustache celiac. Pug banh mi chartreuse echo park, taiyaki small batch next level typewriter kickstarter fam street art schlitz crucifix swag.", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[7].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Telefon", "Gentrify beard gluten-free seitan glossier venmo bespoke typewriter. Bushwick viral copper mug marfa heirloom authentic franzen readymade fanny pack kitsch. Raw denim art party yr leggings literally bicycle rights hoodie tumblr. Butcher readymade letterpress iceland, hashtag vegan pickled succulents tumblr humblebrag polaroid hexagon gastropub. Shoreditch gastropub trust fund man bun, snackwave vexillologist kale chips sriracha. Umami coloring book gentrify palo santo woke 90's butcher.", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[8].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Den røde tråd", "Cliche four loko yr ugh swag lomo tousled banh mi. Succulents tbh austin roof party raclette meh. Godard freegan whatever, vaporware iceland mlkshk gluten-free pour-over ennui intelligentsia hella. Woke prism authentic unicorn, kinfolk roof party pickled raw denim.", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
            _tempElements[9].AddTag(TagCatalog.Instance.Tags["Rock"]);

            _tempElements.Add(new Element("Fandrenge og fanpiger", "Migas waistcoat four dollar toast, church-key direct trade taiyaki poke wayfarers lo-fi cronut seitan. Etsy direct trade pabst kinfolk meggings. You probably haven't heard of them unicorn whatever fam paleo street art cliche banjo ugh twee. Shabby chic yuccie bespoke, cardigan skateboard vape edison bulb. Tofu prism fam man braid mustache cornhole etsy pork belly.", "https://www.youtube.com/embed/kz7JELU29wc", AreaCatalog.Instance.Areas["Pladespillerrummet"]));
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
