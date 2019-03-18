using System;
using System.Collections.Generic;
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
            int count = 0,i,l;
            IList<int> list = new List<int>();
            Console.WriteLine("no. of elements in a given array:");
            l = a.Length;
            for (i = 0;i<l; i++)
            {
                count++;
            }
            list.Add(count);
            for (int m = 0; m < list.Count; m++)
                Console.WriteLine("{0}) {1}", m + 1, list[m]);
            Console.ReadKey();
        }
    }
}