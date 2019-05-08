using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace Ragna_Rundt
{
    public class UdstillingsElement
    {
        private string _description;
        private string _videoLink;
        private string _name;
        private int _primaryKey;
        private static int _pkCount = 1;

        public UdstillingsElement(string description, string videoLink, string name)
        {
            _description = description;
            _videoLink = videoLink;
            _name = name;
            _primaryKey = _pkCount;
            _pkCount++;
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string VideoLink
        {
            get { return _videoLink; }
            set { _videoLink = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int PrimaryKey
        {
            get { return _primaryKey; }
            set { _primaryKey = value; }

        }
    }
}
