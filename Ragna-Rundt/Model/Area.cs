using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ragna_Rundt.Model
{
   public class Area:Tag
    {
        private string _description;
        private int _mapLeft;
        private int _mapTop;
        private string _imgPath;
        private int _floor;

        public Area(string name, string description, int mapLeft, int mapTop, string imgPath, int floor):base(name)
        {
            _description = description;
            _mapLeft = mapLeft;
            _mapTop = mapTop;
            _imgPath = imgPath;
            _floor = floor;
        }
        public string Desciption
        {
            get { return _description; }
        }
        public int MapLeft
        {
            get { return _mapLeft; }
        }
        public int MapTop
        {
            get { return _mapTop; }
        }
        public string ImgPath
        {
            get { return _imgPath; }
        }
        public int Floor
        {
            get { return _floor; }
        }
    }
}
