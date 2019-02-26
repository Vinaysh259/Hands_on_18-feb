using System;


namespace _9
{
    class Program9
    {
        static void Main()
        {
            int l;
            string ch;
            char[] ch1;
            Console.WriteLine("enter the character:");
            ch = Console.ReadLine();
            l = ch.Length;
            ch1 = ch.ToCharArray(0, l);
            if ((ch1[0] >= 'A' && ch1[0] <= 'Z') || (ch1[0] >= 'a' && ch1[0] <= 'z'))
                {
                Console.WriteLine("input is alphabet");
            }
            else if(ch1[0]>=48 &&ch1[0]<=57)
            {
                Console.WriteLine("input is digit");
            }
            else
                Console.WriteLine("invalid");
            Console.ReadKey();
        }
    }
}
