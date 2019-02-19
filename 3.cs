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
            for(i=0;i<l;i++)
            {
                char Last = a[i];
                Last++;
                
                Console.WriteLine(Last);
            }
            
            Console.ReadKey();


        }
    }
}
