using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class program5
    {
        static void Main()
        {
            int l, N, i = 0, c;
            string ch;
            SortedList alpha_list = new SortedList();
            char[] ch1;
            Console.WriteLine("Enter how many characters you are entering :");
            N = int.Parse(Console.ReadLine());

            while (i < N)
            {
                Console.WriteLine("Enter the character:");
                ch = Console.ReadLine();
                l = ch.Length;
                ch1 = ch.ToCharArray(0, l);


                if ((ch1[0] >= 'A' && ch1[0] <= 'Z') || (ch1[0] >= 'a' && ch1[0] <= 'z'))
                {
                    c = 1;
                }
                else if (ch1[0] >= 48 && ch1[0] <= 57)
                {
                    c = 0;
                }
                else
                {
                    Console.WriteLine("invalid");
                    c = 2;
                }


                alpha_list.Add(ch, c);
                i++;

            }

            foreach (DictionaryEntry val in alpha_list)
            {
                if ((int)val.Value == 1)
                    Console.WriteLine("{0} is an alphabet. ", val.Key);
                else
                    Console.WriteLine("{0} is a digit. ", val.Key);
            }
            Console.ReadKey();
        }
    }
}

