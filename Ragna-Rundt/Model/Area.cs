using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ragna_Rundt.Model
{
    class Area:Tag
    {
        private string _description;
        private int _mapX;
        private int _mapY;

        public Area(string name, string description, int mapX, int mapY):base(name)
        {
            _description = description;
            _mapX = mapX;
            _mapY = mapY;
        }
        public string Desciption
        {
            get { return _description; }
        }
        public int MapX
        {
            get { return _mapX; }
        }
        public int MapY
        {
            get { return _mapY; }
        }
    }
}
