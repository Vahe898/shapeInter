using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeInter
{
    internal class Triangel : Shape2D, IPerimetr, IArea
    {
        private double _thirdSide;
        public double ThirdSide
        {
            get { return _thirdSide; }
            set
            {
                if (value > 0)
                {
                    _thirdSide = value;
                }
            }
        }

        

        public Triangel(double length, double width,double third) : base(length, width)
        {
            Length = length;
            Width = width;
            ThirdSide = third;
        }

        
        

        

        public double CalcArea()
        {
            CalcPerimetr();
            return S = Math.Sqrt(P / 2 * (P / 2 - Length) * (P / 2 - Width) * (P / 2 - ThirdSide));
        }

        public double CalcPerimetr()
        {
            return P = Length + Width + ThirdSide;
        
        }
    }
}
