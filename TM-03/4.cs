using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class NegativeNumberException
    {
        public void ValidateMarks(int m)
        {
            if (m < 0)
                throw new Exception("Marks1 is Negative.");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int marks1, marks2, marks3;
            NegativeNumberException n1 = new NegativeNumberException();
            Console.WriteLine("Enter Student Name:");
            str = Console.ReadLine();
            Console.WriteLine("Enter students marks in three subjects :");

            try
            {
                marks1 = int.Parse(Console.ReadLine());
                n1.ValidateMarks(marks1);
                marks2 = int.Parse(Console.ReadLine());
                n1.ValidateMarks(marks2);
                marks3 = int.Parse(Console.ReadLine());
                n1.ValidateMarks(marks3);
            }

            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }

            catch (Exception ex1)
            {
                Console.WriteLine("Exception Occurred!!!!!!!");
                Console.WriteLine(ex1.Message);
            }
            Console.ReadKey();
        }
    }
}
