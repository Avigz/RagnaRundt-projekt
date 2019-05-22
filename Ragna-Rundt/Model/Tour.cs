using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Pickers.Provider;

namespace Ragna_Rundt.Model
{
    public class Tour
    {
        private int _id;
        private string _name;
        private string _description;
        private List<Element> _elements;

        public static int autoIncrement = 1;

        public Tour(string name, string description)
        {
            _name = name;
            _description = description;
            _elements = new List<Element>();
            _id = autoIncrement;
            autoIncrement++;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public List<Element> Elements
        {
            get { return _elements; }
        }

        public void AddElement(Element element)
        {
            _elements.Add(element);
        }
    }
}
