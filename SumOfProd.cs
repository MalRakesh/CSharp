using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfProd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // An application that obtains four int values from the user and displays the sum product

            int no1, no2, no3, no4, product;

            Console.WriteLine("--- Sum Of Numbers ---");

            Console.Write("\nEnter Number 1 : ");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Number 2 : ");
            no2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Number 3 : ");
            no3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Number 4 : ");
            no4 = Convert.ToInt32(Console.ReadLine());

            product = no1 * no2 * no3 * no4;

            Console.Write("\nProduct is " + product);

            Console.ReadKey();
        }
    }
}
