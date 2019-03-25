using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 5, 7 };
            int count = 0, l, i;
            SortedList list = new SortedList();
            Console.WriteLine("no. of elements in a given array:");
            l = a.Length;
            for (i = 0; i < l; i++)
            {
                count++;
            }
            list.Add(1, count);
            foreach (DictionaryEntry val in list)
            {
                Console.WriteLine("{0}) {1}", val.Key, val.Value);
            }

            Console.ReadKey();
        }
    }
}