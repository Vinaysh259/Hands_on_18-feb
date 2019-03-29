using System;
using System.Collections.Generic;
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

            IList<double> list = new List<double>();
            int j = 0;
            Console.WriteLine("Enter the sides");
            while (j < N)
            {

                a = double.Parse(Console.ReadLine());

                double area = a * a;
                list.Add(area);
                j++;

            }


            foreach (var val in list)
            {
                Console.WriteLine("Area = {0}", val);
            }

            Console.ReadKey();
        }
    }
}
