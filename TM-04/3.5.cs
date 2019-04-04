using System;
using System.Collections.Generic;
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

            IList<string> rev_list = new List<string>();
            IList<string> rep_list = new List<string>();
            IList<string> sub_list = new List<string();
            IList<string> mod_list = new List<string>();

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
                rev_list.Add(rev_str);

                Console.WriteLine("Enter the character to be replaced by $ :");
                ch1 = Console.ReadLine();
                str2 = str1.Replace(ch1[0], '$');
                rep_list.Add(str2);


                string sub = str1.Substring(1, l_1 - 1);
                sub_list.Add(sub);


                string str3 = string.Copy(str1);
                str3 = str3 + " Modified";
                mod_list.Add(str3);


                j++;

            }

            foreach (var val in rev_list)
            {
                Console.WriteLine("Reversed String : {0} ", val);

            }
            Console.WriteLine("\n\n");
            Console.ReadKey();



            foreach (var val in rep_list)
            {
                Console.WriteLine("Modified String{0}", val);

            }

            Console.WriteLine("\n\n");
            Console.ReadKey();


            foreach (var val in sub_list)
                Console.WriteLine("Substring :{0}", val);

            Console.WriteLine("\n\n");
            Console.ReadKey();

            foreach (var val in mod_list)
                Console.WriteLine("Modifier Substring :{0}", val);

            Console.ReadKey();
        }
    }
}
