using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.UI.ViewManagement;
using System.Windows.Input;
using Ragna_Rundt.Model;
using Ragna_Rundt.Common;

namespace Ragna_Rundt.Viewmodel
{
    public  class ViewModel : INotifyPropertyChanged
    {
     

		public ElementCatalog Catalog = ElementCatalog.Instance;
        public SearchList searchList = SearchList.Instance;
        

        public static int StaticKey = 1;
        private static int _filterKey;
        //private static int _allFilterKey;

        private ObservableCollection<Tag> _filters;
        private ObservableCollection<Tag> _allFilters;
        private Tag _selectedTag;

        public ViewModel()
        {
            ClearFilterCommand = new RelayCommand(ClearFilter);
            RemoveFilterCommand = new RelayCommand(RemoveFilter);
            AddFilterCommand = new RelayCommand(AddFilter);
            _filters = new ObservableCollection<Tag>();
            _allFilters = new ObservableCollection<Tag>();
        }
       // element
       public int Key
       {
           get { return StaticKey; }
           set
           {
               StaticKey = value;
               OnPropertyChanged();
               OnPropertyChanged(nameof(Name));
               OnPropertyChanged(nameof(VideoLink));
               OnPropertyChanged(nameof(Description));
           }
       }
       public Tag SelectedTag
        {
            get { return _selectedTag; }
            set { _selectedTag = value; }
        }
       public int FilterKey
       {
            get { return _filterKey; }
            set {
                _filterKey = value;
                OnPropertyChanged();
            }
       }    
       public  string VideoLink
       {
           get {return Catalog.Elements[Key].videoURL;}
       }

       public  string Name
       {
           get{ return Catalog.Elements[Key].Name;}
       }

       public string Description
       {
           get { return Catalog.Elements[Key].description; }
       }

       // searchlist
       public Dictionary<int, Element> CurrentList
       {
           get { return SearchList.Instance.CurrentList; }
       }

       public ObservableCollection<Tag> Filters
       {
           get
            {
                
                ObservableCollection<Tag> _filters = new ObservableCollection<Tag>(searchList.Filters);
                return _filters;
            }
       }

       public ObservableCollection<Tag> AllFilters
       {
           get
            {
                
                ObservableCollection<Tag> _allFilters = new ObservableCollection<Tag>(searchList.AllFilters);
                return _allFilters;
            }
       }
       public ICommand AddFilterCommand { get; set; }

        public ICommand RemoveFilterCommand { get; set; }
    
       public ICommand ClearFilterCommand { get; set; }

       public ICommand SearchUpdateCommand { get; set; }
        public string SearchWord
       {
           get { return SearchList.Instance.SearchWord; }
       }
       /*  Methods*/
       public void AddFilter()
        {
            searchList.AddFilter(FilterKey);
            OnPropertyChanged(nameof(Filters));
            OnPropertyChanged(nameof(AllFilters));
            OnPropertyChanged(nameof(CurrentList));
        }

       public void RemoveFilter()
       {
            searchList.RemoveFilter(FilterKey);
            OnPropertyChanged(nameof(Filters));
            OnPropertyChanged(nameof(AllFilters));
            OnPropertyChanged(nameof(CurrentList));
       }

       public void ClearFilter()
       {
           searchList.ClearFilters(); 
           OnPropertyChanged(nameof(Filters));
           OnPropertyChanged(nameof(AllFilters));
           OnPropertyChanged(nameof(CurrentList));
        }

       public void SearchUpdate()
       {
           searchList.Update();
           OnPropertyChanged(nameof(Filters));
           OnPropertyChanged(nameof(AllFilters));
           OnPropertyChanged(nameof(CurrentList));
        }
		
		
		 private bool _tilbageIsVisible = true;
       private bool _næsteIsVisible = true;
       private bool _afslutTourIsVisible = true;

       public bool TilbageIsVisible
       {
           get { return _tilbageIsVisible; }
           set
           {
               _tilbageIsVisible = value;
               OnPropertyChanged(nameof(TilbageIsVisible));
           }
       }

       public bool NæsteIsVisible
       {
           get { return _næsteIsVisible; }
           set
           {
               _næsteIsVisible = value;
               OnPropertyChanged(nameof(NæsteIsVisible));
           }
       }

       public bool AfslutTourIsVisible
       {
           get { return _afslutTourIsVisible; }
           set
           {
               _afslutTourIsVisible = value;
               OnPropertyChanged(nameof(AfslutTourIsVisible));
           }
       }

       public event PropertyChangedEventHandler PropertyChanged;

       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
            PropertyChanged?.Invoke(this,new  PropertyChangedEventArgs(propertyName));
       }

    }
}

