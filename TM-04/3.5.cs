using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class program5
    {
        public static void Main()
        {
            string str1, str2, ch1;
            char[] ch_arr1;
            int l_1;

            int j = 0;

            SortedList rev_list = new SortedList();
            SortedList rep_list = new SortedList();
            SortedList sub_list = new SortedList();
            SortedList mod_list = new SortedList();

            Console.WriteLine("Welcome to Reversing the string Application:");
            Console.WriteLine("Enter the number of strings :");
            int N1 = int.Parse(Console.ReadLine());
            while (j < N1)
            {
                Console.WriteLine("Enter the String :");
                str1 = Console.ReadLine();
                l_1 = str1.Length;
                ch_arr1 = str1.ToCharArray(0, l_1);
                Array.Reverse(ch_arr1);
                string rev_str = new string(ch_arr1);
                rev_list.Add(str1, rev_str);

                Console.WriteLine("Enter the character to be replaced by $ :");
                ch1 = Console.ReadLine();
                str2 = str1.Replace(ch1[0], '$');
                rep_list.Add(str1, str2);


                string sub = str1.Substring(1, l_1 - 1);
                sub_list.Add(str1, sub);


                string str3 = string.Copy(str1);
                str3 = str3 + " Modified";
                mod_list.Add(str1, str3);


                j++;

            }

            foreach (DictionaryEntry val in rev_list)
            {
                Console.WriteLine("Original String : {0} and Reversed String : {1} ", val.Key, val.Value);

            }
            Console.WriteLine("\n\n");
            Console.ReadKey();



            foreach (DictionaryEntry val in rep_list)
            {
                Console.WriteLine("Original String : {0} and Modified String : {1} ", val.Key, val.Value);

            }

            Console.WriteLine("\n\n");
            Console.ReadKey();


            foreach (DictionaryEntry val in sub_list)
                Console.WriteLine("Original String :{0} and Substring :{1}", val.Key, val.Value);

            Console.WriteLine("\n\n");
            Console.ReadKey();

            foreach (DictionaryEntry val in mod_list)
                Console.WriteLine("Original String :{0} and Substring :{1}", val.Key, val.Value);

            Console.ReadKey();
        }
    }
}
