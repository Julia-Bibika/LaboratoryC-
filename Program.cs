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
            var t2 = new TTriangle(10, 5, 7);
            var t3 = new TTriangle(t2);
            var tr1 = new TTrianglePrizm();
            var tr2 = new TTrianglePrizm(3,4,5,1);
            var tr3 = new TTrianglePrizm(tr1);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(TTriangle.count);
            Console.WriteLine(t2.Square());
            Console.WriteLine(t2.Perimetr());
            t1 = 3 * t2 + t2;
            Console.WriteLine(t1);
            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr2.Perimetr());
            Console.WriteLine(tr2.Square());
            Console.ReadLine();
        }

    }
    public class TTriangle
    {
        public static int count;

        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get { return _a; }
            set
            {
                if (value > 0)
                {
                    _a = value;
                }
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                if (value > 0)
                {
                    _b = value;
                }
            }
        }
        public double C
        {
            get { return _c; }
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
            this.A = a;
            this.B = b;
            this.C = c;
            count++;
        }
        public TTriangle()
        {
            this.A = 1;
            this.B = 1;
            this.C = 1;
            count++;
        }
        public TTriangle(TTriangle t)
        {
            this.A = t.A;
            this.B = t.B;
            this.C = t.C;
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
        public double Square()
        {
            double p = (A + B + C) / 2;
            return (Math.Sqrt(p * (p - A) * (p - B) * (p - C)));
        }
        public double Perimetr()
        {
            return A + B + C;
        }
        public bool IsEqual(TTriangle t)
        {
            return A == t.A && B == t.B && C == t.C;
        }
        public static TTriangle operator +(TTriangle t1, TTriangle t2)
        {
            return new TTriangle(t1.A + t2.A, t1.B + t2.B, t1.C + t2.C);
        }
        public static TTriangle operator -(TTriangle t1, TTriangle t2)
        {
            return new TTriangle(t1.A - t2.A, t1.B - t2.B, t1.C - t2.C);
        }
        public static TTriangle operator *(TTriangle t1, double d)
        {
            return new TTriangle(t1.A * d, t1.B * d, t1.C * d);
        }
        public static TTriangle operator *(double d, TTriangle t1)
        {
            return new TTriangle(t1.A * d, t1.B * d, t1.C * d);
        }
    }
    public class TTrianglePrizm : TTriangle
    {
        private double _h;
        public double H
        {
            get { return _h; }
            set
            {
                if (value > 0)
                {
                    _h = value;
                }
            }
        }
        public TTrianglePrizm(double a, double b, double c,double h):base(a,b,c)
        {
            this.H = h;
        }
        public TTrianglePrizm()
        {
            this.A = 1;
            this.B = 1;
            this.C = 1;
            _h = 1;
        }
        public TTrianglePrizm(TTrianglePrizm tr)
        {
            this.A = tr.A;
            this.B = tr.B;
            this.C = tr.C;
            _h = 1;
        }
        public override string ToString()
        {
            return $"a={A} b={B} c={C} h={H}";
        }
        public new double Square()
        {
            return (Perimetr() * H) + (2 * base.Square());
        }
        public double V ()
        {
            return base.Square() * H;
        }
        public bool IsEqual(TTrianglePrizm tr)
        {
            return this.A == tr.A && this.B == tr.B && this.C == tr.C && this.H == tr.H;
        }
        public static TTrianglePrizm operator +(TTrianglePrizm tr1, TTrianglePrizm tr2)
        {
            return new TTrianglePrizm(tr1.A + tr2.A, tr1.B + tr2.B, tr1.C + tr2.C, tr1.H + tr2.H);
        }
        public static TTrianglePrizm operator -(TTrianglePrizm tr1, TTrianglePrizm tr2)
        {
            return new TTrianglePrizm(tr1.A - tr2.A, tr1.B - tr2.B, tr1.C - tr2.C, tr1.H - tr2.H);
        }
        public static TTrianglePrizm operator *(TTrianglePrizm tr1, double d)
        {
            return new TTrianglePrizm(tr1.A * d, tr1.B * d, tr1.C * d, tr1.H * d);
        }
        public static TTrianglePrizm operator *(double d, TTrianglePrizm tr1)
        {
            return new TTrianglePrizm(tr1.A * d, tr1.B * d, tr1.C * d, tr1.H * d);
        }
    }
}
