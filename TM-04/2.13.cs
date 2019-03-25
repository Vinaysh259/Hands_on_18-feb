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
            int i, sum,j=1;
            int[] a = new int[100];
            Console.WriteLine("Enter the Number of inputs : ");
            int N = int.Parse(Console.ReadLine());
            SortedList list = new SortedList();
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
                list.Add(d, sum);
                j++;
            }
            Console.WriteLine("\n");
            foreach (DictionaryEntry val in list)
            {
                Console.WriteLine("array:({0}) ,sum:{1}", val.Key, val.Value);
            }
            Console.ReadKey();
        }
    }
}