using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Class1
    {
        private double _x;
        private double _t;

        public Class1(double x, double t)
        {
            _x = x;
            _t = t;
        }

        public double CalculateB()
        {
            return Math.Pow(Math.Log(Math.Abs(_x)), 2);
        }
        public double CalculateA()
        {
            double b = CalculateB();
            return _t * _x + Math.Abs(Math.Sqrt(b));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Cos(a + Math.Pow(b, 3)), 3);
        }
    }
}