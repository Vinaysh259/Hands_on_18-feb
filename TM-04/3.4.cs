using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace String
{
    class program4
    {
        public static void Main()
        {
            string str1;
            char[] arr1 = new char[100];
            int l, i, j = 0;
            Console.WriteLine("Enter the Number of Strings : ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Input the strings :\n");
            IList<string> list = new List<string>();
            while (j < N)
            {

                str1 = Console.ReadLine();
                l = str1.Length;
                arr1 = str1.ToCharArray(0, l); // Converts string into char array.


                for (i = 0; i < l; i++)
                {

                    if (Char.IsLower(arr1[i]))
                        arr1[i] = Char.ToUpper(arr1[i]);
                    else
                        arr1[i] = Char.ToLower(arr1[i]);
                }
                string toggled_str = new string(arr1);
                list.Add(toggled_str);
                j++;
            }
            Console.Write("\nAfter conversion, the string is :\n");
            for (int k = 0; k < list.Count; k++)
                Console.WriteLine("{0}) {1}", k + 1, list[k]);
            Console.ReadKey();
        }
    }
}
