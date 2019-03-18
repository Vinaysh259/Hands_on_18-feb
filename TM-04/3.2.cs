using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program2
    {
        static void Main()
        {
            string a;
            int alphabets, digits, i = 0, j = 1, l;
            alphabets = digits = 0;
            Console.WriteLine("Count the number of digits,alpabets in a string");
            Console.WriteLine("Enter the Number of Strings : ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the input Strings");
            IList<int> alpha = new List<int>();
            IList<int> digit = new List<int>();
            while (j <= N)
            {
                a = Console.ReadLine();
                l = a.Length;
                alphabets = digits = 0;
                for (i = 0; i < l; i++)
                {
                    if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
                    {
                        alphabets++;
                    }
                    else if (a[i] >= '0' && a[i] <= '9')
                    {
                        digits++;
                    }
                    else { }

                }
                alpha.Add(alphabets);
                digit.Add(digits);
                j++;
            }
            Console.WriteLine("list showing no. of alphabets in the input strings");
                for (int k = 0; k <alpha.Count; k++)
                    Console.WriteLine("{0}) {1}",k+1,alpha[k]);
            Console.WriteLine("list showing no. of digits in the input strings");
            for (int m = 0; m < digit.Count; m++)
                Console.WriteLine("{0}) {1}", m+1, digit[m]);
            Console.ReadKey();
        }
    }
}





