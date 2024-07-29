using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console Application to perform various string operations.

            Console.WriteLine("*** String Operations ***");

            string str1 = "Rakesh", str2 = " Mal";
            Console.WriteLine("\nString1 - " + str1);
            Console.WriteLine("\nString2 - " + str2);

            Console.WriteLine("\n--------------------------");

            //Length
            Console.WriteLine("\nLength of String1 - " + str1.Length);

            //Concat()
            Console.WriteLine("\nConcat() - " + String.Concat(str1, str2));

            //Trim()
            Console.WriteLine("\nTrim() - " + str1.Trim('h'));

            //ToUpper()
            Console.WriteLine("\nToUpper() - " + str1.ToUpper());

            //ToLower()
            Console.WriteLine("\nToLower() - " + str2.ToLower());

            //Substring()
            Console.WriteLine("\nSubstring() - " + str1.Substring(0, 2));

            Console.ReadKey();
        }
    }
}
