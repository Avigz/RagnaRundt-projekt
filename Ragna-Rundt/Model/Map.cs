using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
    class Map
    {
        private int _id;
        private string _name;
        private string _imgPath;

        private static int _autoIncrement = 1;

        public Map(string name, string imgPath)
        {
            _name = name;
            _imgPath = imgPath;
            _id = _autoIncrement;
            _autoIncrement++;
        }
    }
}
