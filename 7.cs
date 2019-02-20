using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            char[] ch_arr1;
            int l_1, c;

            Console.WriteLine("Welcome to Reversing the string Application:");
            Console.WriteLine("Enter the String :");
            str1 = Console.ReadLine();
            l_1 = str1.Length;
            ch_arr1 = str1.ToCharArray(0, l_1);
            Array.Reverse(ch_arr1);
            Console.WriteLine(ch_arr1);
            str2 = ch_arr1.ToString();
            c = string.Compare(str1, str2);
            if (c == -1)
                Console.WriteLine("The string is a Palindrome");
            else
                Console.WriteLine("It's not a Palindrome");
            Console.ReadKey();

        }
    }
}
