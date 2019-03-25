using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main()
        {
            int i, sum, j = 1;
            int[] a = new int[100];
            Console.WriteLine("Enter the Number of inputs : ");
            int N = int.Parse(Console.ReadLine());
            IList<int> list = new List<int>();
            while (j <= N)
            {
                sum = 0;
                Console.Write("enter the elements in the array :\n");
                for (i = 0; i < 10; i++)
                {

                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (i = 0; i < 10; i++)
                {
                    a[i] = a[i];
                }
                for (i = 0; i < 10; i++)
                {

                    sum = sum + a[i];
                }
                string[] original_str = Array.ConvertAll(a, ele => ele.ToString());//converts integer array to string
                string d = string.Join(",", original_str);
                list.Add(sum);
                j++;
            }
            Console.WriteLine("sum list");
            for (int m = 0; m < list.Count; m++)
                Console.WriteLine("{0}) {1}", m + 1, list[m]);
            Console.ReadKey();
        }
    }
}