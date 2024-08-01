using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An application to demonstrate Fibonacci Series

            int previous = -1; int next = 1;
            int position;

            Console.WriteLine("*** Fibonacci Series ***");

            Console.Write("\nEnter the Position - ");

            position = int.Parse(Console.ReadLine());

            Console.Write("\nFibonacci Series - ");
            for (int i = 0; i < position; i++)
            {
                int sum = next + previous;
                previous = next;
                next = sum;

                Console.Write(next + " ");
            }
            Console.ReadKey();
        }         
    }
}
