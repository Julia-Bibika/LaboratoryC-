using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labka2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмірність: ");
             int n = int.Parse(Console.ReadLine());
             int[,] a = new int[n, n];
             int[,] b = new int[n, n];
             Random rnd = new Random();

             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     a[i,j] = rnd.Next(1,10);
                 }
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     Console.Write(a[i, j] + "\t");
                 }
                 Console.WriteLine();
             }
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                    b[i, j] = a[j, i];      
                 }
             }
            Console.WriteLine("Транспонована матриця: ");
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < n; j++)
                 {
                     Console.Write(b[i, j] + "\t");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();
        }

    }
}