using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, digit;
            Console.WriteLine("Question No. 8:");
            Console.WriteLine("Input the Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a single digit :");
            num2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while(num1 != 0)
            {
                digit = num1 % 10;
                if(digit == num2)
                {
                    break;
                }
                else
                {
                    num1 = num1 / 10;
                    count++;
               
                }
                
            }

            switch (count)
            {
                case 0: Console.WriteLine("The second number is in Unit's place of first number.");
                    break;
                case 1: Console.WriteLine("The second number is in Ten's place of first number.");
                    break;
                case 2: Console.WriteLine("The second number is in hundred's place of first number.");
                    break;
                default:Console.WriteLine("The second number is in Thousand's place of first number.");
                    break;
            }

            Console.ReadKey();
        }
    }
   
}
