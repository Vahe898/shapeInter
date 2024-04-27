using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeInter
{
    abstract class Shape2D
    {
        private double _length;
        private double _width;
        public  double P { get; set; }
        public double S { get; set; }

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


        public Shape2D(double length, double width)/*2d i hamar*/
        {
            Length = length;
            Width = width;
        }
        
    }
}
