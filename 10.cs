using System;

namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, digit;
            int count;
            Console.WriteLine("Question No. 10:");
            Console.WriteLine("Input the Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a single digit :");
            num2 = Convert.ToInt32(Console.ReadLine());
            count = 0;

            while (num1 > 0)
            {
                digit = num1 % 10;
                if(digit == num2)
                {
                    count++;
                }

                else
                {

                }

                num1 = num1 / 10;

            }

            Console.WriteLine("Second number occurs {0}", count, "times in the First number");
            Console.ReadKey();
        }
    }
}
