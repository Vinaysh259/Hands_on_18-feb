using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public class Program6
    {
        static void Main()
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, j = 0;
            IList<int> list1 = new List<int>();
            IList<int> list2 = new List<int>();
                Console.Write("Enter number1:\n");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number2:\n");
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = n1;
                n4 = n2;
                n4 = ++n3;
                n5 = n1;
                n6 = n2;
                n6 = n5++;
                n7 = n1;
                n8 = n2;
                int b;
                b = n7;
                n7 = n8;
                n8 = b;
                list1.Add(n3);
                list1.Add(n5);
                list1.Add(n7);
            list2.Add(n4);
            list2.Add(n6);
            list2.Add(n8);
            Console.WriteLine("list showing operations on num1");
            for (int k = 0; k < list1.Count; k++)
                Console.WriteLine("{0}) {1}", k + 1, list1[k]);
            Console.WriteLine("list showing operations on num2");
            for (int m = 0; m < list2.Count; m++)
                Console.WriteLine("{0}) {1}", m + 1, list2[m]);
            Console.ReadKey();
        }
    }
}

