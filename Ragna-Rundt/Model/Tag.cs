using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ragna_Rundt.Model
{
   public class Tag
    {
        private int _id;
        private string _name;
        public static int autoIncrement = 1;

        public Tag(string name)
        {
            _name = name;
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

    }
}
