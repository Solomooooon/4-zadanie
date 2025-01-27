using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._25
{
    class Class3
    {
        private double _x;
        private double _c;

        public Class3(double x, double c)
        {
            _x = x;
            _c = c;
        }

        public double CalculateB()
        {
            return _x + Math.Pow(_c, 2);
        }
        public double CalculateA()
        {
            double b = CalculateB();
            return Math.Pow(Math.Sqrt(Math.Abs(b + _c)), 3);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(a), 4) * Math.Pow(a, 2);
        }
    }
}
