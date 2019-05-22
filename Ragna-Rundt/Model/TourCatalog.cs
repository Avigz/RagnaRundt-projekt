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

            _tempTours.Add(new Tour("DanseFeber Tour", "Flere musikkulturer er opstået på baggrund af dansekulturer, og dans har ofte været det element, der har populariseret ungdoms- og subkulturer."));
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[4]);
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[5]);
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[6]);
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[7]);

            _tempTours.Add(new Tour("Skævle Tour", "Temaet omhandler hvordan ungdomskultur og musik har gået hånd i hånd gennem tiden, og hvordan musik har fungeret som modstandsform, mobilisator og talerør for forskellige ungdomskulturer."));
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[8]);
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[9]);
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[10]);
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[11]);

            _tempTours.Add(new Tour("Blikfang Tour", "I Musikalske strømme kan de besøgende gå på opdagelse i udviklingen af genrer og musikalske strømninger indenfor dansk rock- og popkultur helt tilbage fra jazzens indtog i 1920’erne."));
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[12]);
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[13]);
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[14]);
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[15]);

            _tempTours.Add(new Tour("Musikalske strømme Tour", "Idolfotos og plakater giver fankulturen et boost, og i 1960 raser Otto Brandenburg-feberen, efter at han er blevet lanceret som det første danske teenageidol. Skrig, tatoveringer, autografer, Beatle-mania og meget mere fortæller om fankultur og idoldyrkelse igennem tiden."));
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[16]);
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[17]);
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[18]);
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[19]);

            _tempTours.Add(new Tour("Fandrenge, fanpiger Tour", "Den røde tråd er en digital, kronologisk tidslinje, der, med udgangspunkt i museets samling, belyser dansk rock, pop og ungdomskultur fra 1940’erne og frem til i dag."));
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[20]);
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[21]);
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[22]);
            _tempTours[5].AddElement(ElementCatalog.Instance.Elements[23]);

            _tempTours.Add(new Tour("Den røde tråd Tour", "Den røde tråd er en digital, kronologisk tidslinje, der, med udgangspunkt i museets samling, belyser dansk rock, pop og ungdomskultur fra 1940’erne og frem til i dag."));
            _tempTours[6].AddElement(ElementCatalog.Instance.Elements[24]);
            _tempTours[6].AddElement(ElementCatalog.Instance.Elements[25]);
            _tempTours[6].AddElement(ElementCatalog.Instance.Elements[26]);
            _tempTours[6].AddElement(ElementCatalog.Instance.Elements[27]);

            _tempTours.Add(new Tour("Elektrisk Intimitet Tour", "I dette tema fortæller museet historien om radioprogrammet Det Elektriske Barometer, der i mere end 30 år på DR har sat unges dagligdag, drømme og kærlighed i fokus – med musikken som omdrejningspunkt og pejlemærke"));
            _tempTours[7].AddElement(ElementCatalog.Instance.Elements[28]);
            _tempTours[7].AddElement(ElementCatalog.Instance.Elements[29]);
            _tempTours[7].AddElement(ElementCatalog.Instance.Elements[30]);

            _tempTours.Add(new Tour("Rotation Tour", "Vores musikoplevelse afhænger af teknologi. Dette tema fortæller om os som musikforbrugere, og hvordan vi op gennem tiden har mødt musikken via forskellige teknologier som radioen, pladespilleren, mp3-afspilleren eller streamingtjenester."));
            _tempTours[8].AddElement(ElementCatalog.Instance.Elements[31]);
            _tempTours[8].AddElement(ElementCatalog.Instance.Elements[32]);
            _tempTours[8].AddElement(ElementCatalog.Instance.Elements[33]);
            _tempTours[8].AddElement(ElementCatalog.Instance.Elements[34]);

            _tempTours.Add(new Tour("Jagten på den fede lyd Tour", "BesDemoteket er en lyttestation, hvor museets besøgende kan dykke ned i gamle demo-, live- og alternative udgaver af kendte danske kunstnere.krivelse4"));
            _tempTours[9].AddElement(ElementCatalog.Instance.Elements[35]);
            _tempTours[9].AddElement(ElementCatalog.Instance.Elements[36]);
            _tempTours[9].AddElement(ElementCatalog.Instance.Elements[37]);
            _tempTours[9].AddElement(ElementCatalog.Instance.Elements[38]);

            _tempTours.Add(new Tour("Demoteket Tour", "Musikere har til alle tider dyrket og jagtet den gode lyd. Dette tema følger udviklingen fra akustikken i kirkekrypter og badeværelser, over milliondyre professionelle studier, til DIY-musikeren i soveværelset. Ikonisk for rummet er bl.a. et ægte toilet."));
            _tempTours[10].AddElement(ElementCatalog.Instance.Elements[39]);
            _tempTours[10].AddElement(ElementCatalog.Instance.Elements[40]);
            _tempTours[10].AddElement(ElementCatalog.Instance.Elements[41]);


            _tempTours.Add(new Tour("Ragna-rundt", "En flyvende rejse igennem musikkens historie, alt fra 1920'erne og frem til nutidens bangers"));
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[1]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[2]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[3]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[4]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[5]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[6]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[7]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[8]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[9]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[10]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[11]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[12]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[13]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[14]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[15]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[16]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[17]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[18]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[19]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[20]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[21]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[22]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[23]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[24]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[25]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[26]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[27]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[28]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[29]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[30]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[31]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[32]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[33]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[34]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[35]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[36]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[37]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[38]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[39]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[40]);
            _tempTours[11].AddElement(ElementCatalog.Instance.Elements[41]);

            _tempTours.Add(new Tour("Udvalgt tour","En tour designet for dine interreser"));
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[3]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[12]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[9]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[24]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[38]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[41]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[26]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[17]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[33]);

            _tempTours.Add(new Tour("Udvalgt tour2", "En tour designet for dine interreser"));
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[5]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[22]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[19]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[4]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[28]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[1]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[36]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[40]);
            _tempTours[12].AddElement(ElementCatalog.Instance.Elements[12]);

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
        }
    }
}
