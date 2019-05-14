using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
    class TagCatalog
    {
        private Dictionary<string, Tag> _tags;
        private static TagCatalog _instance;
        private TagCatalog()
        {
            _tags = new Dictionary<string, Tag>();
            _tags.Add("Kim Larsen", new Tag("Kim Larsen"));
            _tags.Add("DAD", new Tag("DAD"));
            _tags.Add("Metallica", new Tag("Metallica"));
            _tags.Add("Rock", new Tag("Rock"));
            _tags.Add("Pop", new Tag("Pop"));
            _tags.Add("Metal", new Tag("Metal"));
            _tags.Add("Undomsoprør", new Tag("Undomsoprør"));
            _tags.Add("Lys Show", new Tag("Lys Show"));
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
