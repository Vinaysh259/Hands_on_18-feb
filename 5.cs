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
            string a;
            int i, l;
            char[] arr;

            Console.WriteLine("Welcome to Reversing the string Application:");
            Console.WriteLine("Enter the String :");
            str1 = Console.ReadLine();
            l_1 = str1.Length;
            ch_arr1 = str1.ToCharArray(0, l_1);
            Array.Reverse(ch_arr1);
            Console.WriteLine("Reversed string is :");
            Console.WriteLine(ch_arr1);
            Console.ReadKey();

            Console.WriteLine("\n\n\n\n");
            string str3, str5;
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

            Console.WriteLine("Enter the input String");
            a = Console.ReadLine();
            l = a.Length;
            //arr1 = a.ToCharArray(0, l);
            string sub = a.Substring(1, l - 1);
            Console.WriteLine("Substring: {0}\n\n\n\n\n", sub);


            string a2 = string.Copy(a);
            arr = a2.ToCharArray(0, l);
            //string output = a2.Replace(a2, "* ");
            Console.WriteLine("::BEFORE::");
            Console.WriteLine(a2);
            Console.WriteLine("::AFTER::");
            for (i = 0; i < l; i++)
            {
                char ch = arr[i];
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch));
            }
            //string output = a2.Replace(a2, "* ");

            //Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}



