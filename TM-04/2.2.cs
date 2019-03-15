using System;
using System.Collections;
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
            SortedList alpha = new SortedList();
            SortedList digit = new SortedList();
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

                alpha.Add(j, alphabets);
                digit.Add(j, digits);

                j++;
            }
            Console.WriteLine("list showing no. of alphabets in the input strings");
            foreach (DictionaryEntry val in alpha)
            {
                Console.WriteLine("string {0}", val.Key);
                Console.WriteLine("{0}) {1}", val.Key, val.Value);

            }
            Console.WriteLine("list showing no. of digits in the input strings");
            foreach (DictionaryEntry val in digit)
            {
                Console.WriteLine("string {0}", val.Key);
                Console.WriteLine("{0}) {1}", val.Key, val.Value);
            }
            Console.ReadKey();


        }
    }

}





