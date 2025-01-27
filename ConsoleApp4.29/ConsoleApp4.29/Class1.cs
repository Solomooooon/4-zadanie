using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._29
{
    class Class1
    {
        private double _b;
        private double _a;

        public Class1(double b, double a)
        {
            _b = b;
            _a = a;
        }

        public double CalculateX()
        {
            return Math.Exp(2 * _a) + Math.Sqrt(_b);
        }
        public double CalculateP()
        {
            double x = CalculateX();
            return x * (_a + Math.Pow(_b, 3));
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double p = CalculateP();
            return Math.Pow(Math.Log(Math.Abs(p)), 3) + x;
        }
    }
}
