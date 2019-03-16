using System;


namespace _11
{
    class Program
    {
        static void Main()
        {
            int i, sum = 0;
            int[] a = new int[100];




            Console.Write("enter the elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values stored in the array : \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.WriteLine("\n\n");
            for (i = 0; i < 10; i++)
            {
                
                sum = sum + a[i];
            }

            Console.WriteLine("the sum of the elements is:{0}", sum);
            Console.ReadKey();

        }
    }
}