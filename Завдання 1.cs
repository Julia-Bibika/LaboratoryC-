using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labka1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            double min1 = Min1int(a, b, c);
            Console.WriteLine(min1);
            double min = Minint(a, b, c);
            Console.WriteLine(min);
            double min2 = Min2int(a, b, c);
            Console.WriteLine(min2);
            double y = min1 + min + min2;
            Console.WriteLine("Y = {0}", y);
        }
        static double Min1int(double a, double b, double c)
        {
            if (a - (Math.Pow(a, 2)) < (c - (Math.Pow(c, 2))))
            {
                return (a - (Math.Pow(a, 2)));
            }
            else
            {
                return (c - (Math.Pow(c, 2)));
            }
        }
        static double Minint(double a, double b, double c)
        {
            if ((Math.Pow(a, 3) - Math.Pow(b, 3)) < (Math.Pow(a, 3)))
            {
                return (Math.Pow(a, 3) - Math.Pow(b, 3));
            }
            else
            {
                return (Math.Pow(a, 3));
            }
        }
        static double Min2int(double a, double b, double c)
        {
            if ((Math.Pow(a, 2) + 3 * b - 4) < (Math.Pow(c, 2) + 2 * c + 1))
            {
                return (Math.Pow(a, 2) - Math.Pow(b, 2));
            }
            else
            {
                return (Math.Pow(b, 2) + Math.Pow(c, 2));
            }
        }
    }
}