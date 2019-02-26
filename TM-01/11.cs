using System;


namespace program11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int count = 0;
            Console.WriteLine("Enter the elements of the array:");
            for(; ; )
            {
                string str = Console.ReadLine();
                
                
                if( str[0] < 48 && str[0] > 57)
                {
                    break;
                }

                else
                {
                    a[count] = Convert.ToInt32(str);
                    count++;
                }
            }

            Console.WriteLine("The array contains {0}", count, "elements");
        }
    }
}
