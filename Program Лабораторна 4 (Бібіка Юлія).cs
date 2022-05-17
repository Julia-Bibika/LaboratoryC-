using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new TTriangle();
            var t2 = new TTriangle(10,5,7);
            var t3 = new TTriangle(t2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(TTriangle.count);
            Console.WriteLine(t1.Square(t2));
            Console.WriteLine(t1.Perimetr(t2));
            t1 =  3*t2 + t2;
            Console.WriteLine(t1);

            Console.ReadLine();
        }

    }
    internal class TTriangle
    {
        public static int count;

        private double _a;
        private double _b;
        private double _c;

        public double A { get { return _a; } 
            set 
            { 
                if(value > 0)
                {
                    _a = value;
                }
            } 
        }
        public double B { get { return _b; } 
            set 
            {
                if (value > 0)
                {
                    _b = value;
                }
            } 
        }
        public double C { get { return _c; } 
            set 
            {
                if (value > 0)
                {
                    _c = value;
                }
            } 
        }
        public TTriangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            count++;
        }
        public TTriangle()
        {
            _a = 1;
            _b = 1;
            _c = 1;
            count++;
        }
        public TTriangle(TTriangle t)
        {
            _a = t._a;
            _b = t._b;
            _c = t._c;
            count++;
        }
        static TTriangle()
        {
            count = 0;
        }
        public override string ToString()
        {
            return string.Format($"a={_a} b={_b} c={_c}");
        }
        public double Square(TTriangle t)
        {
            double p = (t._a + t._b + t._c)/2;
            return Math.Sqrt(p*(p - t._a)*(p - t._b)*(p - t._c));
        }
        public double Perimetr(TTriangle t)
        {
            return t._a + t._b + t._c;
        }
        public bool IsEqual(TTriangle t)
        {
            return _a == t._a && _b == t._b && _c == t._c;
        }
        public static TTriangle operator +(TTriangle t1, TTriangle t2)
        {
            return new TTriangle(t1._a + t2._a, t1._b + t2._b,t1._c + t2._c);
        }
        public static TTriangle operator -(TTriangle t1, TTriangle t2)
        {
            return new TTriangle(t1._a - t2._a, t1._b - t2._b,t1._c - t2._c);
        }
        public static TTriangle operator *(TTriangle t1 , double d)
        {
            return new TTriangle(t1._a * d, t1._b * d,t1._c * d);
        }
        public static TTriangle operator *(double d, TTriangle t1)
        {
            return new TTriangle(t1._a * d, t1._b * d,t1._c*d);
        }
    }
}
