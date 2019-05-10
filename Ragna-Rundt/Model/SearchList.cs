using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Rag.Domain
{
    class SearchList
    {
        private ElementCatalog _allElements;
        private AreaCatalog _allAreas;
        private TagCatalog _allTags;

        private List<Element> _currentList;
        private Area _area;
        private List<Tag> _filters;
        private string _searchWord;

        private static SearchList _instance;

        private SearchList()
        {
            _allElements = ElementCatalog.Instance;
            _currentList = _allElements.Elements;
            _searchWord = "";

        }
        public static SearchList Instance
        {
            get
            {
                if (_instance == null) _instance = new SearchList();
                return _instance;
            }
        }
        public List<Element> CurrentList
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

        //filter
        public void Filter(List<Tag> filters)
        {
            List<Element> filterList = new List<Element>();
            foreach(Element element in _currentList)
            {
                bool exists = false;
                foreach(Tag tag in element.Tags)
                {
                    if (filters.Exists(x=>x.Id==tag.Id)) exists = true;
                }
                if (!exists) filterList.Add(element);
            }
            _currentList = filterList;
        }
        public void AddFilter(Tag tag)
        {
            if(!_filters.Exists(x => x.Id == tag.Id)) _filters.Add(tag);
        }
        public void RemoveFilter(Tag tag)
        {
            _filters.Remove(tag);
        }
        public void ClearFilters()
        {
            _filters.Clear();
        }
        //areafilter
        public void AreaFilter()
        {
            List<Element> returnList = new List<Element>();
            foreach(Element element in _currentList)
            {
                if (_area == element.Area) returnList.Add(element);
            }
            _currentList = returnList;
        }
        //search
        public void Search()
        {
            string word = _searchWord.Replace(" ", ".*");
            word = ".*" + word + ".*";
            List<Element> returnList = new List<Element>();

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

            foreach (Element element in _currentList)
            {
                if (Regex.Match(element.Name, word).Success||(areas.Count>0&&areas.Exists(x=>x.Id==element.Area.Id))) returnList.Add(element);
                else if (tagMatches.Count > 0)
                {
                    bool exists = false;
                    foreach(Tag tag in element.Tags)
                    {
                        if (tagMatches.Exists(x => x.Id == tag.Id)) exists = true;
                    }
                    if (exists) returnList.Add(element);
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
