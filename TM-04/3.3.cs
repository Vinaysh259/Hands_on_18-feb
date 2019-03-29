using System;
using System.Collections.Generic;
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
            int l;

            Console.WriteLine("Enter the Number of Strings : ");
            int N = int.Parse(Console.ReadLine());
            IList<string> list = new List<string>();
            int i, j = 0;
            while (j < N)
            {
                Console.WriteLine("Enter the input String");
                a = Console.ReadLine();

                char[] Last = new char[100];
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
                list.Add(Last_str);
                j++;

            }


            foreach (var val in list)
            {
                Console.WriteLine("Updated String = {0}", val);
            }

            Console.ReadKey();


        }
    }
}
