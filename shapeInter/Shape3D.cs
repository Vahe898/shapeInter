using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeInter
{
    abstract class Shape3D
    {
        private double _length;
        private double _width;
        private double _height; 
        
        public double Length
        {
            get { return _length; }
            set 
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }
        public double V { get; set; }
        //public  Shape(double length, double width)/*2d i hamar*/
        //{
        //    Length = length;
        //    Width = width;
        //}
        public Shape3D(double length, double width,double height) /*3d i hamar*/
        {
            Length = length;
            Width = width;
            Height = height;
        }


    }
}
