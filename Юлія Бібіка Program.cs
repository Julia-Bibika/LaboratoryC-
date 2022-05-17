using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labka3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[2];
            b[0] = 0;
            b[1] = n-1;
            int[] a = new int[n];
            Random rnd = new Random();
            for(int i = 0;i < n; i++)
            {
                a[i] = rnd.Next(1,10);
            }
            Queue queue = new Queue(b,a);
            queue.Remove( ref a,2,b);
            queue.Insert(ref a,5,3,b);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]}" + "\t");
            }
            Console.WriteLine($"sum = {queue.Sum(a)}");
            Console.WriteLine($"{ queue.ToString()}"); 
        }

    }
    public class Queue
    {
        private int[] _firstandlast;
        private int[] _numbers;
        public Queue(int[] firstandlast,int[] numbers)
        {
            _firstandlast = firstandlast;
            _numbers = numbers;
        }
        public int[] Insert(ref int[] _numbers,int value,int index,int[] _firstandlast)
        {
            int[] newNumbers = new int[_numbers.Length + 1];
            newNumbers[index] = value;
            
            for(int i = 0; i < index; i++)
                newNumbers[i] = _numbers[i];
            for(int i = index; i < index; i++)
                newNumbers[i+1] = _numbers[i];
            _numbers = newNumbers;
            _firstandlast[1] = _numbers.Length - 1;
            return _numbers;
        }
        public int[] Remove(ref int[] _numbers, int index, int[] _firstandlast)
        {
            int[] newNumbers = new int[_numbers.Length - 1];
            for (int i = 0; i < index; i++)
                newNumbers[i] = _numbers[i];
            for(int i = index+1; i< _numbers.Length;i++)
                newNumbers[i - 1] = _numbers[i];

            _numbers = newNumbers;
            _firstandlast[1] = _numbers.Length - 1;
            return _numbers;
        }
        public int Sum(int[] _numbers)
        {
            int sum = 0;
            for(int i = 0;i < _numbers.Length; i++)
            {
                sum += _numbers[i]; 
            }
            return sum;
        }
        public override string ToString()
        {
            return string.Format($"{_firstandlast},{_numbers}");
        }

        public int[] Firstandlast { get { return _firstandlast; } set { _firstandlast = value; } }
        public int[] Numbers{ get { return _numbers; } set { _numbers = value; } }
    }
}