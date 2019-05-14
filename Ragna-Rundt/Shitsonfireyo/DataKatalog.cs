using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace Ragna_Rundt.Model

{
    public class DataKatalog
    {
        private  Dictionary<int,UdstillingsElement> _udstillingsElementer = new Dictionary<int, UdstillingsElement>();

        public DataKatalog()
        {
            UdstillingsElement a1 = new UdstillingsElement($"Spejle: Cred put a bird on it jianbing yr vexillologist schlitz lumbersexual lo-fi 8-bit neutra farm-to-table squid tumblr migas. Flannel cornhole freegan lumbersexual sartorial beard, knausgaard austin authentic synth artisan VHS iceland 8-bit raw denim. You probably haven't heard of them vegan everyday carry tbh farm-to-table. Tousled cray coloring book ugh art party XOXO vegan, cronut taiyaki helvetica single-origin coffee hexagon tilde. Gastropub cornhole copper mug keytar. Marfa vaporware humblebrag put a bird on it 3 wolf moon stumptown trust fund fashion axe.", "https://www.youtube.com/embed/s9jOm4Lbj-U?autoplay=1", "Spejl Rummet");
            UdstillingsElement a2 = new UdstillingsElement($"Lys: Gluten-free snackwave heirloom, man braid pour-over adaptogen selfies kale chips shabby chic venmo vegan sriracha cray authentic. Sustainable retro jean shorts, tilde thundercats chia normcore helvetica kombucha 90's single-origin coffee. Franzen tattooed lomo post-ironic, portland bitters cliche fashion axe lumbersexual letterpress woke. Microdosing kickstarter tbh vexillologist salvia stumptown four loko cray raclette 3 wolf moon keffiyeh succulents ennui.", "https://www.youtube.com/embed/j7bCPcABspg?autoplay=1", "Lys Show");
            UdstillingsElement a3 = new UdstillingsElement($"Goegl: Organic food truck occupy man bun, tote bag narwhal artisan photo booth farm-to-table raw denim iPhone actually copper mug heirloom. Migas art party chillwave street art selvage, etsy heirloom. 3 wolf moon microdosing beard hashtag crucifix twee mixtape. Listicle chicharrones tumeric kombucha photo booth yr edison bulb green juice flexitarian four loko poke lumbersexual cronut umami.", "https://www.youtube.com/embed/_sh6MDFJdNU??autoplay=1", "Goegl");

            _udstillingsElementer.Add(1,a1);
            _udstillingsElementer.Add(2,a2);
            _udstillingsElementer.Add(3,a3);
        }

        public  Dictionary<int, UdstillingsElement> UdstillingsElementer
        {
            get { return _udstillingsElementer; }
            set { _udstillingsElementer = UdstillingsElementer; }
        }

        public  void Add(int key, UdstillingsElement Element)
        {
            _udstillingsElementer.Add(key,Element);
           
        }

        public string VideoLink(int key)
        {
            return UdstillingsElementer[key].VideoLink;
        }

        public string Name(int key)
        {
            return UdstillingsElementer[key].Name;
        }

        public string Description(int key)
        {
            return UdstillingsElementer[key].Description;
        }
    }
}
