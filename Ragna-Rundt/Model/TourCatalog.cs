using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ragna_Rundt.Model
{
    public class TourCatalog
    {
        private List<Tour> _tempTours;
        private Dictionary<int, Tour> _tours;
        private static TourCatalog _instance;

        private TourCatalog()
        {
            _tempTours = new List<Tour>();

            _tempTours.Add(new Tour("Lad der bliver lys Tour", "Musik er også en visuel oplevelse, og lys er i dag en integreret del af det musikalske udtryk ved koncerter og festivaler, men sådan har det ikke altid været."));
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[0]);
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[1]);
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[2]);
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[3]);
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[17]);
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[18]);

            _tempTours.Add(new Tour("DanseFeber Tour", "Flere musikkulturer er opstået på baggrund af dansekulturer, og dans har ofte været det element, der har populariseret ungdoms- og subkulturer."));
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[4]);
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[5]);
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[6]);
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[7]);
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[19]);

            _tempTours.Add(new Tour("Skælve Tour", "Temaet omhandler hvordan ungdomskultur og musik har gået hånd i hånd gennem tiden, og hvordan musik har fungeret som modstandsform, mobilisator og talerør for forskellige ungdomskulturer."));
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[8]);
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[9]);
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[10]);
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[11]);

            _tempTours.Add(new Tour("Musikalske Strømme Tour", "I Musikalske strømme kan de besøgende gå på opdagelse i udviklingen af genrer og musikalske strømninger indenfor dansk rock- og popkultur helt tilbage fra jazzens indtog i 1920’erne."));
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[12]);
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[13]);
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[14]);
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[15]);

            _tempTours.Add(new Tour("Fans og Fankultur Tour", "Idolfotos og plakater giver fankulturen et boost, og i 1960 raser Otto Brandenburg-feberen, efter at han er blevet lanceret som det første danske teenageidol. Skrig, tatoveringer, autografer, Beatle-mania og meget mere fortæller om fankultur og idoldyrkelse igennem tiden."));
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[16]);
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[17]);
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[18]);
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[19]);

            _tempTours.Add(new Tour("Den Røde Tråd Tour", "Den røde tråd er en digital, kronologisk tidslinje, der, med udgangspunkt i museets samling, belyser dansk rock, pop og ungdomskultur fra 1940’erne og frem til i dag."));
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[20]);
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[21]);
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[22]);
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[23]);
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[24]);

          
            
            _tours = new Dictionary<int, Tour>();

            foreach (Tour tour in _tempTours)
            {
                _tours.Add(tour.Id, tour);
            }
        }

        public static TourCatalog Instance
        {
            get
            {
                if (_instance == null) _instance = new TourCatalog();
                return _instance;
            }
            
        }

        public Dictionary<int, Tour> Tours
        {
            get { return _tours; }
            set { _tours = value; }
        }
    }
}
