using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._26
{
    class Class1
    {
        private double _t;
        private double _b;

        public Class1(double t, double b)
        {
            _t = t;
            _b = b;
        }

        public double CalculateA()
        {
            return Math.Sqrt(_b + Math.Pow(_t, 2));
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(Math.Cos(_b), 2) + Math.Pow(Math.Sin(a), 2);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double x = CalculateX();
            return Math.Pow(x, 2) + Math.Pow(Math.Sqrt(Math.Abs(x)), 3);
        }
    }
}
