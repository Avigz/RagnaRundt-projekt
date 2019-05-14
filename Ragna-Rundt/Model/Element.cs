using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
    public class Element
    {
        private int _id;
        private string _name;
        private string _description;
        private string _videoURL;
        private List<Tag> _tags;
        private Area _area;

        public static int autoIncrement = 1;

        public Element(string name, string description, string videoURL, Area area)
        {
            _name = name;
            _description = description;
            _videoURL = videoURL;
            _area = area;
            _tags = new List<Tag>();
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
        public string description
        {
            get { return _description; }
        }
        public string videoURL
        {
            get { return _videoURL; }
        }
        public Area Area
        {
            get { return _area; }
        }
        public List<Tag> Tags
        {
            get { return _tags; }
        }

        public void AddTag(Tag tag)
        {
            _tags.Add(tag);
        }
    }
}
