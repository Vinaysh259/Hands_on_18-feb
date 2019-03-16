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
            int count = 0,l,i;
            ArrayList list = new ArrayList();
            Console.WriteLine("no. of elements in a given array:");
            l = a.Length;
            for (i = 0; i < l; i++)
            {
                count++;
            }
            list.Add(count);
            foreach (var val in list)
                Console.WriteLine(val);
            
            Console.ReadKey();
        }
    }
}
