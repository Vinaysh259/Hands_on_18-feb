using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public class Program6
    {
        static void Main()
        { 
            int n1, n2,n3,n4,n5,n6,n7,n8, j = 0;
            Console.WriteLine("Enter the Number of inputs : ");
            int N = int.Parse(Console.ReadLine());
            SortedList pre = new SortedList();
            SortedList post = new SortedList();
            SortedList swap = new SortedList();
            while (j < N)
            {
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
                pre.Add(n3, n4);
                post.Add(n5, n6);
                swap.Add(n7, n8);
                j++;
               
            }
            Console.WriteLine("pre list:");
            foreach (DictionaryEntry val in pre)
            {
               
                Console.WriteLine("{0} , {1}", val.Key, val.Value);

            }
            Console.WriteLine("post list:");
            foreach (DictionaryEntry val in post)
            {

                Console.WriteLine("{0} , {1}", val.Key, val.Value);

            }
            Console.WriteLine("swap list:");
            foreach (DictionaryEntry val in swap)
            {

                Console.WriteLine("{0} , {1}", val.Key, val.Value);

            }
            Console.ReadKey();
            }
        }
    }

