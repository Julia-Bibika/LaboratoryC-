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
            Console.WriteLine(Z2());
        }
        static string Z2()
        {
            Console.WriteLine("Zavd 2");
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[4];
            int numb = number;
            for (int i = 3; i >= 0; i--)
            {
                numbers[i] = number % 10;
                number = number / 10;
            }
            number = numb;
            int max = 0;
            for (int i = 0; i < 4; i++)
            {
                if (number % 10 > max)
                    max = number % 10;
                number = number / 10;
            }

            number = numb;


            int min = 9;
            for (int i = 0; i < 4; i++)
            {
                if (number % 10 < min)
                    min = number % 10;
                number = number / 10;
            }


            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] == min)
                {
                    numbers[i] = max;
                    i++;

                }
                if (numbers[i] == max)
                {
                    numbers[i] = min;
                    i++;

                }
            }


            return String.Join("", numbers);
        }
    }
}