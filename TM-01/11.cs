using System;


namespace program11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 5, 7 };
            int count = 0, l, i;
            Console.WriteLine("no. of elements in a given array:");
            l = a.Length;
            for (i = 0; i < l; i++)
            {
                count++;
            }


            Console.WriteLine("The array contains {0} elements", count);
            Console.ReadKey();
        }
    }
}
