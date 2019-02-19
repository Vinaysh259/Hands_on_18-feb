using System;

namespace String
{
    class program5
    {
        public static void Main()
        {
            string str1;
            char[] ch_arr1;
            int l_1;
            Console.WriteLine("Welcome to Reversing the string Application:");
            Console.WriteLine("Enter the String :");
            str1 = Console.ReadLine();
            l_1 = str1.Length;
            ch_arr1 = str1.ToCharArray(0,l_1);
            Array.Reverse(ch_arr1);
            Console.WriteLine("Reversed string is :");
            Console.WriteLine(ch_arr1);
            Console.ReadKey();

            Console.WriteLine("\n\n\n\n");
            string str3,str5;
            string ch1;
            char[] ch_arr3;
            int l_3;
            Console.WriteLine("Welcome to Replacing any given Character by '$' symbol :  ");
            Console.WriteLine("Enter the string :");
            str3 = Console.ReadLine();
            Console.WriteLine("Enter the character to be replaced by $ :");
            ch1 = Console.ReadLine();
            l_3 = str3.Length;
            ch_arr3 = str3.ToCharArray(0, l_3);
            str5 = str3.Replace(ch1[0], '$');
            Console.WriteLine(str5);
            Console.ReadKey();
        }
    }
}
