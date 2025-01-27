using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик2
{
    internal class Class1
    {
       
        private double _x = 1.3;
        private double _k = 4;
        private double _e;
        

        public Class1(double x, double k, double e)
        {
            _x = x;
            _k = k;
            _e = e;
            
        }
       
        public void _a()
        {
            Console.WriteLine($"Y = {Math.Log(Math.Abs(_x))}");
        }
        public void _b()
        {
            Console.WriteLine($"Y = {Math.Pow(_e, 2 * _x) + (_a) * (_x)}");
        }
        public void Y()
        {
            Console.WriteLine($"Y = {_x * Math.Pow(_a, 3) + Math.Pow(_b, 2)}");
        }
    }
}
