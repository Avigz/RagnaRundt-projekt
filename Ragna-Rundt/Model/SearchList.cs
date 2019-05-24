using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ragna_Rundt.Model
{
   public class SearchList
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
            _allAreas = AreaCatalog.Instance;
            _allTags = TagCatalog.Instance;
           

            _currentList = _allElements.Elements;

            _filters = new List<Tag>();
            _allFilters = new List<Tag>();
            _searchWord = "";

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
        public List<Tag> Filters
        {
            get { return _filters; }
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
                if (filters.Count > 0)
                {
                    bool notExists = false;
                    foreach (Tag tag in filters)
                    {
                        //only adds if matches all tags in filters
                        if (!element.Value.Tags.Exists(x => x.Id == tag.Id)) notExists = true;
                    }
                    if (!notExists) filterList.Add(element.Key, element.Value);
                }
            }
            _currentList = filterList;
        }
        public void AddFilter(int key)  
        {
            if (!_filters.Exists(x => x.Id == key))
            {
                _filters.Add(_allFilters.Find(x => x.Id == key));
                _allFilters.Remove(_allFilters.Find(x => x.Id == key));
                Update();

            }
        }
        public void RemoveFilter(int key)
        {
            if (!_allFilters.Exists(x => x.Id == key))
            {
                _allFilters.Add(_filters.Find(x => x.Id == key));
                _filters.Remove(_filters.Find(x => x.Id == key));
                Update();
            }
        }
        public void ClearFilters()
        {
            foreach (Tag filter in _filters)
            {
                _allFilters.Add(filter);
            }
            _filters.Clear();
            Update();
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
            Array words = Regex.Split(_searchWord, @"\s+");
            Dictionary<int,Element> returnList = new Dictionary<int, Element>();

            List<Tag> tagMatches = new List<Tag>();
            List<Area> areas = new List<Area>(); ;

            if (_filters.Count == 0)
            {
                foreach (Tag tag in _allTags.Tags.Values)
                {
                    bool allMatch = true;
                    foreach (string word in words)
                    {
                        if (!Regex.Match(tag.Name, word, RegexOptions.IgnoreCase).Success) allMatch = false;
                    }
                    if(allMatch)tagMatches.Add(tag);
                }
            }
            if (_area == null)
            {
                foreach (Area area in _allAreas.Areas.Values)
                {
                    bool allMatch = true;
                    foreach (string word in words)
                    {
                        if (!Regex.Match(area.Name, word, RegexOptions.IgnoreCase).Success) allMatch = false;
                    }
                    if(allMatch)areas.Add(area);
                }
            }

            foreach (var element in _currentList)
            {
                bool allMatch = true;
                foreach(string word in words)
                {
                    if(!Regex.Match(element.Value.Name, word, RegexOptions.IgnoreCase).Success)allMatch = false;
                }
                if (allMatch||(areas.Count>0&&areas.Exists(x=>x.Id==element.Value.Area.Id))) returnList.Add(element.Key,element.Value);
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
