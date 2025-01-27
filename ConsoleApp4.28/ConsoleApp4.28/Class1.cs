using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._28
{
    class Class1
    {
        private double _b;
        private double _k;

        public Class1(double b, double k)
        {
            _b = b;
            _k = k;
        }

        public double CalculateT()
        {
            return Math.Pow(_k, 2) + Math.Sqrt(_b);
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return _b + Math.Pow(t, 2) * Math.Exp(1);
        }
        public double CalculateY()
        {
            double t = CalculateT();
            double a = CalculateA();
            return Math.Pow(Math.Cos(Math.Pow(a, 3) + _b), 4);
        }
    }
}
