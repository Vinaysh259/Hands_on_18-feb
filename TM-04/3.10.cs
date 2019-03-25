using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, digit, j = 1;
            int count;

            Console.WriteLine("Enter the Number of inputs : ");
            int N = int.Parse(Console.ReadLine());
            IList<int> list = new List<int>();
            while (j <= N)
            {
                Console.WriteLine("Input num1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input a single digit to be searched in num1:");
                num2 = Convert.ToInt32(Console.ReadLine());
                count = 0;

                while (num1 > 0)
                {
                    digit = num1 % 10;
                    if (digit == num2)
                    {
                        count++;
                    }

                    else
                    {

                    }

                    num1 = num1 / 10;

                }
                list.Add(count);
                j++;
            }
            for (int m = 0; m < list.Count; m++)
                Console.WriteLine("{0}) {1}", m + 1, list[m]);
            Console.ReadKey();
        }
    }
}
