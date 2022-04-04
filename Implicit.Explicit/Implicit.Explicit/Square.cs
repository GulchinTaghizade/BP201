using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit.Explicit
{
    class Square : Figure
    {

        private double _side1;
        public double Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                if (value > 0)
                {
                    _side1 = value;
                }
            }
        }
        public override void CalcArea()
        {
            double area = _side1*_side1;
            Console.WriteLine(area);

        }
    }
}
