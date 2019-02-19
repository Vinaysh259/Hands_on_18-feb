using System;


namespace String
{
    class Program3
    {
        static void Main()
        {
            string a;
            int i, l;

            Console.WriteLine("Enter the input String");
            a = Console.ReadLine();
            l = a.Length;
            for (i = 0; i < l; i++)
            {
                char Last = a[i];
                Last++;
                if (a[i] == 'z')
                    Console.WriteLine('a');
                else if (a[i] == 'Z')
                    Console.WriteLine('A');
                else
                {
                    Console.WriteLine(Last);
                }
            }

            Console.ReadKey();


        }
    }
}
