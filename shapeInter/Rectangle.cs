using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeInter
{
    internal class Rectangle : Shape2D, IArea, IPerimetr
    {
        public Rectangle(double length, double width) : base(length, width)
        {
            Length = length;
            Width = width;

        }

        public double CalcArea()
        {
            return S = Length * Width;
        }

        public double CalcPerimetr()
        {
            return P = 2 * (Length + Width);
        }
    }
}
