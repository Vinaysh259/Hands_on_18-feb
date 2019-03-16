using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main()
        {
            int i, n,N,j=1;
            int[] a = new int[100];
            int[] a_reverse = new int[100];
            Console.WriteLine("Enter the Number of inputs : ");
            N = int.Parse(Console.ReadLine());
            SortedList list1 = new SortedList();
            while (j <= N)
            {
                Console.Write("Input the number of elements to store in the array {0}:", j);
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input {0} number of elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (i = 0; i < n; i++)
                {
                    a[i] = a[i];
                   
                }
                for (i = n - 1; i >= 0; i--)
                {
                    a_reverse[(n-1)-i] = a[i];
                    
                }
                string[] original_str = Array.ConvertAll(a, ele => ele.ToString());//converts integer array to string
                string d = string.Join(",", original_str);
                string[] reverse_str = Array.ConvertAll(a_reverse, ele => ele.ToString());
                string e=string.Join(",", reverse_str);
                list1.Add(d, e);
                j++;
           }
                foreach (DictionaryEntry val in list1)
                {
                    Console.WriteLine("original:({0}) ,reverse: ({1})",val.Key, val.Value);
                }
            Console.ReadKey();
        }
    }
}
