using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._22
{
    class Class1
    {
        private double _m;
        private double _p;

        public Class1(double m, double p)
        {
            _m = m;
            _p = p;
        }

        public double CalculateT()
        {
            return Math.Sin(Math.Pow(_m, 3));
        }
        public double CalculateX()
        {
            double t = CalculateT();
            return Math.Pow(_p, 2) + t;
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double t = CalculateT();
            return Math.Pow(Math.Log(Math.Abs(x + t)), 4);
        }
    }
}
