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
            Console.Write("Введіть розмірність: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rnd = new Random();
            int[] b = new int[n];
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1,10);
            }
            b[0] = -a[0];
            var znak = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
            for(int j = 1;j < n; j++)
            {
                b[j] = b[j - 1] + (znak * a[j]);
                znak = -znak;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + "\t");
            }
            for(int i = 0; i < n; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                }
            }
            Console.WriteLine($"max = {max}"); 
            Console.ReadLine();
        }
        
    }
}