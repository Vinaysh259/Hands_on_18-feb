using System;
using System.Collections.Generic;
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

            IList<string> list = new List<string>();
            IList<string> pal_list = new List<string>();


            Console.WriteLine("Welcome to Reversing the string Application:");
            Console.WriteLine("Enter the number of strigs :");
            N = int.Parse(Console.ReadLine());

            while (i < N)
            {
                Console.WriteLine("Enter the String :");
                str1 = Console.ReadLine();
                list.Add(str1);
                l_1 = str1.Length;
                ch_arr1 = str1.ToCharArray(0, l_1);
                Array.Reverse(ch_arr1);
                str2 = ch_arr1.ToString();
                pal_list.Add(str2);
                i++;
            }



            for (int j = 0; j < list.Count; j++)
            {

                if (string.Compare(list[j], pal_list[j]) == -1)
                    Console.WriteLine("{0} is a Palindrome", list[j]);
                else
                    Console.WriteLine("{0} is not a Palindrome", list[j]);

            }
            Console.ReadKey();

        }
    }
}
