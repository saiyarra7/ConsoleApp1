using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            String[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            double s = 0;
            double n = 2.0;
            s = (a + b + c) / n;
            double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine(Area);
        }
    }
}
