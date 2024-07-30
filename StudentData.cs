using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* An application that receives the (Student Id, Student Name, Course Name, Date of Birth) information from a
              set of students. The application should also display the information of all the students once the data entered. */

            Console.WriteLine("*** Students Data ***");

            int i, j, num;
            int[] student_id = new int[7];
            string[] student_name = new string[30];
            string[] student_course = new string[30];
            string[] student_dob = new string[10];

            Console.WriteLine("\n--- Enter Students Details ---");

            Console.Write("\nEnter the number of students - ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("\n--- Student no. " + i + "---");

                Console.Write("\nStudent ID - ");
                student_id[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nStudent Name - ");
                student_name[i] = Console.ReadLine();

                Console.Write("\nCourse Name - ");
                student_course[i] = Console.ReadLine();

                Console.Write("\nDate Of Birth - ");
                student_dob[i] = Console.ReadLine();

                Console.Write("");

            }

            Console.WriteLine("\n--------------------------");

            Console.WriteLine("\n*** Display Students Details ***");

            for (j = 1; j <= num; j++)
            {
                
                Console.WriteLine("\n--- Student no. " + j + "---");

                Console.Write("\nStudent ID - " + student_id[j]);

                Console.Write("\nStudent Name - " + student_name[j]);

                Console.Write("\nCourse Name - " + student_course[j]);

                Console.Write("\nDate Of Birth - " + student_dob[j]);

                Console.WriteLine("");

            }

            Console.ReadKey();

        }
    }
}
