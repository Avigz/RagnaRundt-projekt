using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ragna_Rundt.Model
{
    class SearchList
    {
        private ElementCatalog _allElements;
        private AreaCatalog _allAreas;
        private TagCatalog _allTags;

        private Dictionary<int,Element> _currentList;
        private Area _area;
        private List<Tag> _filters;
        private List<Tag> _allFilters;
        private string _searchWord;

        private static SearchList _instance;

        private SearchList()
        {
            _allElements = ElementCatalog.Instance;
            _currentList = _allElements.Elements;
            _searchWord = "";
            _allFilters = new List<Tag>();
            foreach (var tag in _allTags.Tags)
            {
                _allFilters.Add(tag.Value);
            }
   

        }
        public static SearchList Instance
        {
            get
            {
                if (_instance == null) _instance = new SearchList();
                return _instance;
            }
        }
        public Dictionary<int,Element> CurrentList
        {
            get { return _currentList; }
            set { _currentList = value; }
        }
        public Area Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public string SearchWord
        {
            get { return _searchWord; }
            set { _searchWord = value; }
        }

        public List<Tag> AllFilters
        {
            get { return _allFilters; }
        }

        //filter
        public void Filter(List<Tag> filters)
        {
            Dictionary<int,Element> filterList = new Dictionary<int, Element>();
            foreach(var element in _currentList)
            {
                bool exists = false;
                foreach(Tag tag in element.Value.Tags)
                {
                    if (filters.Exists(x=>x.Id==tag.Id)) exists = true;
                }
                if (!exists) filterList.Add(element.Key,element.Value);
            }
            _currentList = filterList;
        }
        public void AddFilter(Tag tag)
        {
            if (!_filters.Exists(x => x.Id == tag.Id))
            {
                _filters.Add(tag);
                _allFilters.Remove(tag);

            }
        }
        public void RemoveFilter(Tag tag)
        {
            _filters.Remove(tag);
            _allFilters.Add(tag);
        }
        public void ClearFilters()
        {
            foreach (Tag filter in _filters)
            {
                _allFilters.Add(filter);
            }
            _filters.Clear();
        }
        //areafilter
        public void AreaFilter()
        {
            Dictionary<int,Element> returnList = new Dictionary<int, Element>();
            foreach(var element in _currentList)
            {
                if (_area == element.Value.Area) returnList.Add(element.Key,element.Value);
            }
            _currentList = returnList;
        }
        //search
        public void Search()
        {
            string word = _searchWord.Replace(" ", ".*");
            word = ".*" + word + ".*";
            Dictionary<int,Element> returnList = new Dictionary<int, Element>();

            List<Tag> tagMatches = new List<Tag>();
            List<Area> areas = new List<Area>(); ;

            if (_filters.Count == 0)
            {
                foreach (Tag tag in _allTags.Tags.Values)
                {
                    if (Regex.Match(tag.Name, word).Success) tagMatches.Add(tag);
                }
            }
            if (_area == null)
            {
                foreach (Area area in _allAreas.Areas.Values)
                {
                    if (Regex.Match(area.Name, word).Success) areas.Add(area);
                }
            }

            foreach (var element in _currentList)
            {
                if (Regex.Match(element.Value.Name, word).Success||(areas.Count>0&&areas.Exists(x=>x.Id==element.Value.Area.Id))) returnList.Add(element.Key,element.Value);
                else if (tagMatches.Count > 0)
                {
                    bool exists = false;
                    foreach(Tag tag in element.Value.Tags)
                    {
                        if (tagMatches.Exists(x => x.Id == tag.Id)) exists = true;
                    }
                    if (exists) returnList.Add(element.Key, element.Value);
                }
            }
          
            _currentList = returnList;
        }
        //updatelist
        public void Update()
        {
            _currentList = _allElements.Elements;
            if (_area != null) AreaFilter();
            if(_filters.Count>0)Filter(_filters);
            Search();
        }
    }
}
