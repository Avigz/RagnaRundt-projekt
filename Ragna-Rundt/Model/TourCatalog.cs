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

            _tempTours.Add(new Tour("DAD Tour", "Beskrivelse"));
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[1]);
            _tempTours[0].AddElement(ElementCatalog.Instance.Elements[2]);

            _tempTours.Add(new Tour("Kim Larsen Tour", "Beskrivelse1"));
            _tempTours[1].AddElement(ElementCatalog.Instance.Elements[2]);


            _tempTours.Add(new Tour("Lars Ulrichs Tour", "Beskrivelse2"));
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[1]);
            _tempTours[2].AddElement(ElementCatalog.Instance.Elements[2]);

            _tempTours.Add(new Tour("Disco Tour", "Beskrivelse3"));
            _tempTours[3].AddElement(ElementCatalog.Instance.Elements[3]);

            _tempTours.Add(new Tour("Pladespiller Tour", "Beskrivelse4"));
            _tempTours[4].AddElement(ElementCatalog.Instance.Elements[4]);

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
