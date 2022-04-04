using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit.Explicit
{
    class Rectangle : Figure
    {
        private double _side1;
        public double Side1 {
            get
            {
                return _side1;
            }
            set 
            {
                if (value>0)
                {
                    _side1 = value;
                }
            }
        }
        private double _side2;
        public double Side2
        {
            get
            {
                return _side2;
            }
            set
            {
                if (value > 0)
                {
                    _side2 = value;
                }
            }
        }

        public override void CalcArea()
        {
            double area = _side1 * _side2;
            Console.WriteLine(area);
        }
    }
}
