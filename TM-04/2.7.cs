using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class program5
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            char[] ch_arr1;
            int l_1, c, N, i = 0;

            SortedList pal_list = new SortedList();

            Console.WriteLine("Welcome to Reversing the string Application:");
            Console.WriteLine("Enter the number of strigs :");
            N = int.Parse(Console.ReadLine());

            while (i < N)
            {
                Console.WriteLine("Enter the String :");
                str1 = Console.ReadLine();
                l_1 = str1.Length;
                ch_arr1 = str1.ToCharArray(0, l_1);
                Array.Reverse(ch_arr1);
                str2 = ch_arr1.ToString();
                c = string.Compare(str1, str2);
                pal_list.Add(str1, c);
                i++;
            }


            foreach (DictionaryEntry val in pal_list)
            {

                if ((int)val.Value == -1)
                    Console.WriteLine("{0} is a Palindrome", val.Key);
                else
                    Console.WriteLine("{0} is not a Palindrome", val.Key);

            }
            Console.ReadKey();

        }
    }
}
