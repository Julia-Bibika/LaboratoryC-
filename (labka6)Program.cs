using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class TVSeries
    {
        protected double first;
        protected double rate;

        public TVSeries(double first, double rate)
        {
            this.first = first;
            this.rate = rate;
        }
        public abstract double getSum(int n);
        public abstract double getNth(int n);

        public String getInfo()
        {
            String type = this.GetType().Name;
            return "This is a " + type + " class with fisrt: " + this.first + " and rate: " + this.rate;
        }
    }

    public class TGSeries : TVSeries
    {
        public TGSeries(double first, double rate) : base(first, rate) { }

        public override double getSum(int n)
        {
            return this.first * Math.Pow(this.rate, n - 1) / (this.rate - 1);
        }

        public override double getNth(int n)
        {
            return this.first * Math.Pow(this.rate, n - 1);
        }
    }

    public class TASeries : TVSeries
    {
        public TASeries(double first, double rate) : base(first, rate) { }

        public override double getSum(int n)
        {
            return n * (2 * this.first + this.rate * (n - 1)) / 2;
        }

        public override double getNth(int n)
        {
            return this.first + this.rate * (n - 1);
        }
    }



    public class Program
    {
        public static void Main()
        {
            int Point2_N = 5; // this should be read from user input
            int Point2_M = 6; // this should be read from user input

            var R = new Random();
            var N = 100; //R.Next(1,10);
            TVSeries[] series = new TVSeries[N];
            for (int i = 0; i < N; i++)
            {
                double first = R.Next(1, 10);
                double rate = R.Next(1, 5);
                int type = R.Next(2);
                Console.WriteLine(type);
                if (type == 1)
                {
                    series[i] = new TASeries(first, rate);
                }
                else
                {
                    series[i] = new TGSeries(first, rate);
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("#" + i + ": " + series[i].getInfo());
            }

            var maxNidx = 0;
            var maxN = series[0].getNth(Point2_N);
            for (int i = 1; i < N; i++)
            {
                if (maxN < series[i].getNth(Point2_N))
                {
                    maxNidx = i;
                    maxN = series[i].getNth(Point2_N);
                }
            }

            Console.WriteLine("Series with MAX Nth number is " + maxNidx + " sum of its M elements is " + series[maxNidx].getSum(Point2_M));
        }
    }
}


