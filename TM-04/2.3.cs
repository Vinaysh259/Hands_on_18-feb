using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace String
{
    class Program3
    {
        static void Main()
        {
            string a;
            char[] Last = new char[100];
            int l;

            Console.WriteLine("Enter the Number of Strings : ");
            int N = int.Parse(Console.ReadLine());
            SortedList list = new SortedList();
            int i, j = 0;
            while (j < N)
            {
                Console.WriteLine("Enter the input String");
                a = Console.ReadLine();

                l = a.Length;
                for (i = 0; i < l; i++)
                {

                    if (a[i] == 'z')
                        Last[i] = 'a';
                    else if (a[i] == 'Z')
                        Last[i] = 'A';
                    else
                    {
                        Last[i] = a[i];
                        Last[i]++;
                    }
                }

                string Last_str = new string(Last);
                list.Add(a, Last_str);
                j++;

            }


            foreach (DictionaryEntry val in list)
            {
                Console.WriteLine("Original String = {0}  Updated String = {1}", val.Key, val.Value);
            }

            Console.ReadKey();


        }
    }
}
