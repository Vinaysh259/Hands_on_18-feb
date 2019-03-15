using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace String
{
    class Program1
    {
        static void Main()
        {
            double a;
            char[] Last = new char[100];


            Console.WriteLine("Enter the Number of Sides : ");
            int N = int.Parse(Console.ReadLine());
            SortedList list = new SortedList();
            int j = 0;
            Console.WriteLine("Enter the sides");
            while (j < N)
            {

                a = double.Parse(Console.ReadLine());

                double area = a * a;
                list.Add(a, area);
                j++;

            }


            foreach (DictionaryEntry val in list)
            {
                Console.WriteLine("side = {0}  area = {1}", val.Key, val.Value);
            }

            Console.ReadKey();
        }
    }
}
