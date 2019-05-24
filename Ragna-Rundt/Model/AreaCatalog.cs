using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
    public class AreaCatalog
    {
        private Dictionary<string, Area> _areas;
        private static AreaCatalog _instance;

        private AreaCatalog()
        {
            _areas = new Dictionary<string, Area>();
            _areas.Add("Lad der blive lys", new Area("Lad der blive lys", "Bespoke YOLO tousled copper mug knausgaard wayfarers cronut, green juice lyft commodo consequat. Mixtape cardigan reprehenderit listicle dreamcatcher cillum aliqua anim fugiat id qui adaptogen. Aliqua air plant in, everyday carry actually copper mug health goth narwhal salvia franzen PBR&B consectetur. Echo park artisan portland, officia schlitz leggings minim poutine poke quinoa etsy tumblr.", 247, 288, "../Assets/Knaplysshowgul.png", 3));
            _areas.Add("Dansefeber", new Area("Dansefeber", "Fixie dreamcatcher health goth gluten-free bespoke. +1 asymmetrical tacos farm-to-table narwhal. VHS roof party blog, blue bottle chicharrones etsy craft beer celiac flexitarian drinking vinegar succulents wolf. Enamel pin four dollar toast tumeric stumptown leggings knausgaard. Green juice single-origin coffee sustainable, literally cray la croix celiac quinoa.", 23, 263, "../Assets/KnapVerdengul.png", 3));
            _areas.Add("Skælv", new Area("Skælv", "Hell of tumeric cred gochujang meditation 3 wolf moon affogato lyft lo-fi. Vegan artisan kombucha pork belly occupy thundercats salvia direct trade kickstarter etsy poke yr williamsburg stumptown activated charcoal. Everyday carry live-edge brunch, roof party air plant VHS pork belly thundercats flexitarian vexillologist. Pug four loko plaid tofu pitchfork. Thundercats neutra asymmetrical, narwhal coloring book dreamcatcher authentic bespoke ramps kombucha fingerstache.", 285, 175, "../Assets/KnapSkaelvgul.png", 3));
            _areas.Add("Blikfang", new Area("Blikfang", "Literally you probably haven't heard of them roof party vinyl dreamcatcher mustache selfies ugh drinking vinegar scenester iceland yuccie williamsburg palo santo. Ennui viral VHS asymmetrical ramps. Pinterest VHS squid kombucha knausgaard synth DIY small batch letterpress disrupt freegan bespoke la croix. Heirloom poke vice, cray selfies pinterest ennui. Mumblecore freegan vexillologist raw denim tousled, yuccie tumeric polaroid chia. Pork belly whatever listicle, lo-fi mumblecore church-key bicycle rights cold-pressed small batch health goth. Actually bespoke chillwave semiotics organic retro XOXO shoreditch venmo selvage.", 348, 37, "../ Assets / KnapBlikfanggul.png", 3));
            _areas.Add("Musikalske strømme", new Area("Musikalske strømme", "Narwhal bitters direct trade, etsy kombucha salvia tbh bicycle rights thundercats iPhone messenger bag kale chips freegan. Ethical tacos swag street art, offal typewriter retro taiyaki cloud bread echo park lo-fi cornhole fingerstache prism. Poutine semiotics pour-over, kombucha enamel pin adaptogen paleo craft beer hexagon thundercats fingerstache shabby chic bicycle rights cloud bread live-edge. Before they sold out vexillologist mixtape etsy selvage skateboard, gluten-free salvia green juice brunch cronut. Cred everyday carry organic 90's seitan activated charcoal taxidermy, lyft single-origin coffee artisan fashion axe disrupt beard microdosing iPhone. Paleo waistcoat woke cred.", 510, 238, "../Assets/KnapMusikVaaggul.png", 3));
            _areas.Add("Fandrenge og fanpiger", new Area("Fandrenge og fanpiger", "Selvage flannel adaptogen glossier pug, cray raclette. Raclette XOXO etsy farm-to-table post-ironic biodiesel chartreuse. Gluten-free squid retro, selfies cloud bread wolf air plant. Lyft palo santo beard cray wolf.", 798, 226, "../Assets/KnapHjerteGrøn.png", 2));
            _areas.Add("Den røde tråd", new Area("Den røde tråd", "Unicorn pabst ramps vape. Enamel pin PBR&B biodiesel, pinterest cred health goth echo park actually craft beer succulents semiotics meggings plaid roof party. Fashion axe pabst leggings, activated charcoal letterpress wolf iceland. Glossier selfies etsy, banh mi bespoke farm-to-table lo-fi kitsch live-edge raw denim everyday carry dreamcatcher typewriter jean shorts. Shabby chic cloud bread ugh, slow-carb salvia PBR&B shoreditch master cleanse.", 510, 422, "../Assets/KnapRoedeTraadgul.png", 2));
            _areas.Add("Elektrisk intimitet", new Area("Elektrisk intimitet", "Cardigan chia bushwick typewriter tbh fashion axe next level coloring book hexagon. Asymmetrical direct trade VHS, prism narwhal tumeric taiyaki mumblecore offal chambray hell of blue bottle humblebrag schlitz. Chambray lumbersexual echo park art party knausgaard aesthetic migas mustache waistcoat godard portland affogato unicorn offal 8-bit. Umami man braid butcher, hammock poke messenger bag tousled venmo godard deep v intelligentsia letterpress. Mustache prism umami, twee cray meggings messenger bag man bun banjo trust fund vegan af fanny pack.", 509, 62, "../Assets/KnapTelefongul.png", 2));
            _areas.Add("Rotation", new Area("Rotation", "Slow-carb banjo air plant street art, YOLO messenger bag cray lyft tilde subway tile +1 affogato humblebrag celiac cred. Pabst literally banjo prism, kogi brooklyn green juice fingerstache truffaut. Street art messenger bag offal single-origin coffee thundercats. Shabby chic poke try-hard, truffaut before they sold out sustainable hot chicken food truck pork belly hell of kitsch. Tofu biodiesel authentic hot chicken, marfa pok pok gluten-free sustainable helvetica kogi vexillologist live-edge brooklyn meditation raclette. Bespoke gochujang taxidermy shoreditch.", 347, 200, "../Assets/KnapPladespillergul.png", 2));
            _areas.Add("Jagten på den fede lyd", new Area("Jagten på den fede lyd", "Echo park ugh pour-over vape gochujang. Bushwick authentic bicycle rights VHS man bun squid forage sriracha pabst celiac. Brooklyn cold-pressed microdosing poke, letterpress shaman marfa biodiesel health goth chartreuse neutra yuccie. Leggings migas pok pok hot chicken, ethical craft beer williamsburg celiac jean shorts aesthetic.", 85, 202, "../Assets/KnapTrommegul.png", 2));
            _areas.Add("Demoteket", new Area("Demoteket", "Meggings palo santo stumptown food truck. Brooklyn microdosing gastropub, retro trust fund banjo prism tilde direct trade lumbersexual enamel pin chia. Man bun shabby chic shoreditch brunch plaid taiyaki trust fund. Freegan kogi hella, dreamcatcher activated charcoal polaroid DIY lomo tbh typewriter. Activated charcoal disrupt palo santo succulents asymmetrical pug. Street art bushwick enamel pin freegan. Mumblecore etsy salvia, gochujang kombucha brunch pabst vexillologist banjo.", 210, 29, "../Assets/KnapKassetteBaandgul.png", 2));

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
