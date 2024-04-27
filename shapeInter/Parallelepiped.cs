using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeInter
{
    internal class Parallelepiped : Shape3D, IVolume
    {
        public Parallelepiped(double length, double width, double height) : base(length, width, height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double CalcVolume()
        {
            return V = Length*Width*Height;
        }
    }
}
