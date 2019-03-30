using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main()
        {
            string a;
            int alphabets, digits, i = 0, j = 1, l;
            alphabets = digits = 0;
            Console.WriteLine("Enter the Number of Strings : ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the input Strings");
            SortedList<int,char> alphaList = new SortedList<int, char>();
            SortedList<int,char> digitList = new SortedList<int,char>();
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
                alphaList.Add(alphabets,',');
                digitList.Add(digits,',');
                j++;
            }
            Console.WriteLine("list showing no. of alphabets in the input strings:");
            foreach (KeyValuePair<int, char> kvp in alphaList)
                Console.Write("{0} ", kvp.Key);
            Console.WriteLine("\nlist showing no. of digits in the input strings:");
            foreach (KeyValuePair<int, char> kvp in digitList)
                Console.Write("{0} ", kvp.Key);
            Console.ReadKey();
        }
    }
}





