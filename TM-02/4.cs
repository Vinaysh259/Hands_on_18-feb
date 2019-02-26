using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class RandomHelper
    {
        

        public static int RandInt(int num1,int num2)
        {
            Random rnd = new Random();
            return rnd.Next(num1, (num2 + 1));
        }

        public static double RandDouble(double num1,double num2)
        {
            Random rnd = new Random();
            return rnd.NextDouble();
        }

        
    }

    class RandomHelper_test
    {
        static void Main(string[] args)
        {
            int num1, num2,rnd;
            double rnd1;
            Console.WriteLine("Welcome to Random number generation");
            Console.WriteLine("Enter two limits for generating random number :");
            Console.WriteLine("Number1 :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number2 :");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Random Integer : ");
            rnd=RandomHelper.RandInt(num1, num2);
            Console.WriteLine(rnd);
            Console.WriteLine("Random Double :");
            rnd1 = RandomHelper.RandDouble(num1, num2);
            Console.WriteLine(rnd1);
            Console.ReadKey();
        }
    } 

}


